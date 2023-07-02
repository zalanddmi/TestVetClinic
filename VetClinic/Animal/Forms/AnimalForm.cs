using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.animal.Controllers;
using VetClinic.animal.Models;
using VetClinic.data;
using VetClinic.interfaces;

namespace VetClinic.animal.Forms
{
    public partial class AnimalForm : Form, IForm
    {
        private readonly IController<Animal> _animalController;
        private bool isAdd;

        public AnimalForm()
        {
            InitializeComponent();
            _animalController = new AnimalController();
            ShowRecords();
            ChangeVisibleGroupBox(false);
        }

        public void AddRecord()
        {
            object[] values = new object[]
            {
                textBoxName.Text,
                dateTimePickerBirthDate.Value,
                textBoxTypeAnimal.Text,
                comboBoxSex.SelectedIndex,
                comboBoxOwner.SelectedValue
            };
            _animalController.AddRecord(values);
        }

        public void ChangeVisibleGroupBox(bool isVisible)
        {
            groupBoxAnimal.Visible = isVisible;
            dataGridViewAnimals.Enabled = !isVisible;
            buttonAdd.Visible = !isVisible;
            buttonUpdate.Visible = !isVisible;
            buttonDelete.Visible = !isVisible;
        }

        public void DeleteRecord()
        {
            int id = (int)dataGridViewAnimals.CurrentRow.Cells["id"].Value;
            _animalController.DeleteRecord(id);
        }

        public void ShowRecords()
        {
            dataGridViewAnimals.Rows.Clear();
            var records = _animalController.GetAllRecords();
            foreach (var record in records)
            {
                dataGridViewAnimals.Rows.Add(record);
            }
        }

        public void UpdateRecord()
        {
            object[] values = new object[]
            {
                textBoxName.Text,
                dateTimePickerBirthDate.Value,
                textBoxTypeAnimal.Text,
                comboBoxSex.SelectedIndex,
                comboBoxOwner.SelectedValue
            };
            int id = (int)dataGridViewAnimals.CurrentRow.Cells["id"].Value;
            _animalController.UpdateRecord(id, values);
        }

        private void ClearBoxes()
        {
            textBoxName.Text = string.Empty;
            dateTimePickerBirthDate.Value = DateTime.Now;
            textBoxTypeAnimal.Text = string.Empty;
            comboBoxSex.SelectedIndex = 0;
            comboBoxOwner.SelectedIndex = 0;
        }

        private void RefreshComboBoxes()
        {
            comboBoxOwner.DataSource = null;
            var owners = new VetClinicContext().Owner.ToList();
            comboBoxOwner.DataSource = owners;
            comboBoxOwner.DisplayMember = "fio";
            comboBoxOwner.ValueMember = "id_owner";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ChangeVisibleGroupBox(true);
            RefreshComboBoxes();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            isAdd = false;
            ChangeVisibleGroupBox(true);
            RefreshComboBoxes();
            int id = (int)dataGridViewAnimals.CurrentRow.Cells["id"].Value;
            var animal = _animalController.GetRecord(id);
            textBoxName.Text = (string)animal[0];
            dateTimePickerBirthDate.Value = (DateTime)animal[1];
            textBoxTypeAnimal.Text = (string)animal[2];
            comboBoxSex.SelectedIndex = (bool)animal[3] ? 1 : 0;
            comboBoxOwner.SelectedValue = animal[4];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimals.CurrentRow != null)
            {
                try
                {
                    DeleteRecord();
                    ShowRecords();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChangeVisibleGroupBox(false);
            ClearBoxes();
            ShowRecords();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd)
                {
                    AddRecord();
                }
                else
                {
                    UpdateRecord();
                }
                ChangeVisibleGroupBox(false);
                ClearBoxes();
                ShowRecords();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
