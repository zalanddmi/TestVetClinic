using System;
using System.Windows.Forms;
using VetClinic.interfaces;
using VetClinic.service.Controllers;

namespace VetClinic.service.Forms
{
    public partial class ServiceForm : Form, IForm
    {
        private readonly IController _serviceController;
        private bool isAdd;

        public ServiceForm()
        {
            InitializeComponent();
            _serviceController = new ServiceController();
            ShowRecords();
            ChangeVisibleGroupBox(false);
        }

        public void AddRecord()
        {
            object[] values = new object[]
            {
                textBoxName.Text,
                textBoxDescription.Text,
                textBoxPrice.Text
            };
            _serviceController.AddRecord(values);
        }

        public void ChangeVisibleGroupBox(bool isVisible)
        {
            groupBoxService.Visible = isVisible;
            dataGridViewServices.Enabled = !isVisible;
            buttonAdd.Visible = !isVisible;
            buttonUpdate.Visible = !isVisible;
            buttonDelete.Visible = !isVisible;
        }

        public void DeleteRecord()
        {
            int id = (int)dataGridViewServices.CurrentRow.Cells["id"].Value;
            _serviceController.DeleteRecord(id);
        }

        public void ShowRecords()
        {
            dataGridViewServices.Rows.Clear();
            var records = _serviceController.GetAllRecords();
            foreach (var record in records)
            {
                dataGridViewServices.Rows.Add(record);
            }
        }

        public void UpdateRecord()
        {
            object[] values = new object[]
            {
                textBoxName.Text,
                textBoxDescription.Text,
                textBoxPrice.Text
            };
            int id = (int)dataGridViewServices.CurrentRow.Cells["id"].Value;
            _serviceController.UpdateRecord(id, values);
        }

        private void ClearBoxes()
        {
            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
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
            int id = (int)dataGridViewServices.CurrentRow.Cells["id"].Value;
            var service = _serviceController.GetRecord(id);
            textBoxName.Text = (string)service[0];
            textBoxDescription.Text = (string)service[1];
            textBoxPrice.Text = service[2].ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow != null)
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
