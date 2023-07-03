using System;
using System.Windows.Forms;
using VetClinic.doctor.Controllers;
using VetClinic.interfaces;

namespace VetClinic.doctor.Forms
{
    public partial class DoctorForm : Form, IForm
    {
        private readonly IController _doctorController;
        private bool isAdd;

        public DoctorForm()
        {
            InitializeComponent();
            _doctorController = new DoctorController();
            ShowRecords();
            ChangeVisibleGroupBox(false);
        }

        public void AddRecord()
        {
            object[] values = new object[]
            {
                textBoxFio.Text,
                textBoxSpecialization.Text
            };
            _doctorController.AddRecord(values);
        }

        public void ChangeVisibleGroupBox(bool isVisible)
        {
            groupBoxDoctor.Visible = isVisible;
            dataGridViewDoctors.Enabled = !isVisible;
            buttonAdd.Visible = !isVisible;
            buttonUpdate.Visible = !isVisible;
            buttonDelete.Visible = !isVisible;
        }

        public void DeleteRecord()
        {
            int id = (int)dataGridViewDoctors.CurrentRow.Cells["id"].Value;
            _doctorController.DeleteRecord(id);
        }

        public void ShowRecords()
        {
            dataGridViewDoctors.Rows.Clear();
            var records = _doctorController.GetAllRecords();
            foreach (var record in records)
            {
                dataGridViewDoctors.Rows.Add(record);
            }
        }

        public void UpdateRecord()
        {
            object[] values = new object[]
            {
                textBoxFio.Text,
                textBoxSpecialization.Text
            };
            int id = (int)dataGridViewDoctors.CurrentRow.Cells["id"].Value;
            _doctorController.UpdateRecord(id, values);
        }

        private void ClearBoxes()
        {
            textBoxFio.Text = string.Empty;
            textBoxSpecialization.Text = string.Empty;
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
            int id = (int)dataGridViewDoctors.CurrentRow.Cells["id"].Value;
            var doctor = _doctorController.GetRecord(id);
            textBoxFio.Text = (string)doctor[0];
            textBoxSpecialization.Text = (string)doctor[1];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow != null)
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
