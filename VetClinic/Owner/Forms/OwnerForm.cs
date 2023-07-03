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
using VetClinic.interfaces;
using VetClinic.owner.Controllers;

namespace VetClinic.owner.Forms
{
    public partial class OwnerForm : Form, IForm
    {
        private readonly IController _animalController;
        private bool isAdd;

        public OwnerForm()
        {
            InitializeComponent();
            _animalController = new OwnerController();
            ShowRecords();
            ChangeVisibleGroupBox(false);
        }

        public void AddRecord()
        {
            object[] values = new object[]
            {
                textBoxFio.Text,
                textBoxPassport.Text,
                textBoxAddress.Text,
                textBoxPhone.Text,
            };
            _animalController.AddRecord(values);
        }

        public void ChangeVisibleGroupBox(bool isVisible)
        {
            groupBoxOwner.Visible = isVisible;
            dataGridViewOwners.Enabled = !isVisible;
            buttonAdd.Visible = !isVisible;
            buttonUpdate.Visible = !isVisible;
            buttonDelete.Visible = !isVisible;
        }

        public void DeleteRecord()
        {
            int id = (int)dataGridViewOwners.CurrentRow.Cells["id"].Value;
            _animalController.DeleteRecord(id);
        }

        public void ShowRecords()
        {
            dataGridViewOwners.Rows.Clear();
            var records = _animalController.GetAllRecords();
            foreach (var record in records)
            {
                dataGridViewOwners.Rows.Add(record);
            }
        }

        public void UpdateRecord()
        {
            object[] values = new object[]
            {
                textBoxFio.Text,
                textBoxPassport.Text,
                textBoxAddress.Text,
                textBoxPhone.Text,
            };
            int id = (int)dataGridViewOwners.CurrentRow.Cells["id"].Value;
            _animalController.UpdateRecord(id, values);
        }

        private void ClearBoxes()
        {
            textBoxFio.Text = string.Empty;
            textBoxPassport.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ChangeVisibleGroupBox(true);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            isAdd = false;
            ChangeVisibleGroupBox(true);
            int id = (int)dataGridViewOwners.CurrentRow.Cells["id"].Value;
            var animal = _animalController.GetRecord(id);
            textBoxFio.Text = (string)animal[0];
            textBoxPassport.Text = (string)animal[1];
            textBoxAddress.Text = (string)animal[2];
            textBoxPhone.Text = (string)animal[3];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwners.CurrentRow != null)
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
