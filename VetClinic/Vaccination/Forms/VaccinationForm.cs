using System;
using System.Windows.Forms;
using VetClinic.animal.Models;
using VetClinic.animal.Repositories;
using VetClinic.doctor.Models;
using VetClinic.doctor.Repositories;
using VetClinic.interfaces;
using VetClinic.service.Models;
using VetClinic.service.Repositories;
using VetClinic.vaccination.Controllers;

namespace VetClinic.vaccination.Forms
{
    public partial class VaccinationForm : Form, IForm
    {
        private readonly IController _vaccinationController;
        private readonly IRepository<Animal> _animalRepository;
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IRepository<Service> _serviceRepository;
        private bool isAdd;

        public VaccinationForm()
        {
            InitializeComponent();
            _vaccinationController = new VaccinationController();
            _animalRepository = new AnimalRepository();
            _doctorRepository = new DoctorRepository();
            _serviceRepository = new ServiceRepository();
            ShowRecords();
            ChangeVisibleGroupBox(false);
        }

        public void AddRecord()
        {
            object[] values = new object[]
            {
                dateTimePickerDateVac.Value,
                comboBoxAnimal.SelectedValue,
                comboBoxDoctor.SelectedValue,
                comboBoxService.SelectedValue
            };
            _vaccinationController.AddRecord(values);
        }

        public void ChangeVisibleGroupBox(bool isVisible)
        {
            groupBoxVaccination.Visible = isVisible;
            dataGridViewVaccinations.Enabled = !isVisible;
            buttonAdd.Visible = !isVisible;
            buttonUpdate.Visible = !isVisible;
            buttonDelete.Visible = !isVisible;
        }

        public void DeleteRecord()
        {
            int id = (int)dataGridViewVaccinations.CurrentRow.Cells["id"].Value;
            _vaccinationController.DeleteRecord(id);
        }

        public void ShowRecords()
        {
            dataGridViewVaccinations.Rows.Clear();
            var records = _vaccinationController.GetAllRecords();
            foreach (var record in records)
            {
                dataGridViewVaccinations.Rows.Add(record);
            }
        }

        public void UpdateRecord()
        {
            object[] values = new object[]
            {
                dateTimePickerDateVac.Value,
                comboBoxAnimal.SelectedValue,
                comboBoxDoctor.SelectedValue,
                comboBoxService.SelectedValue
            };
            int id = (int)dataGridViewVaccinations.CurrentRow.Cells["id"].Value;
            _vaccinationController.UpdateRecord(id, values);
        }

        private void ClearBoxes()
        {
            dateTimePickerDateVac.Value = DateTime.Now;
            comboBoxAnimal.SelectedIndex = 0;
            comboBoxDoctor.SelectedIndex = 0;
            comboBoxService.SelectedIndex = 0;
        }

        private void RefreshComboBoxes()
        {
            comboBoxAnimal.DataSource = null;
            var animals = _animalRepository.GetAll();
            comboBoxAnimal.DataSource = animals;
            comboBoxAnimal.DisplayMember = "name";
            comboBoxAnimal.ValueMember = "id_animal";

            comboBoxDoctor.DataSource = null;
            var doctors = _doctorRepository.GetAll();
            comboBoxDoctor.DataSource = doctors;
            comboBoxDoctor.DisplayMember = "fio";
            comboBoxDoctor.ValueMember = "id_doctor";

            comboBoxService.DataSource = null;
            var services = _serviceRepository.GetAll();
            comboBoxService.DataSource = services;
            comboBoxService.DisplayMember = "name";
            comboBoxService.ValueMember = "id_service";
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
            int id = (int)dataGridViewVaccinations.CurrentRow.Cells["id"].Value;
            var vaccination = _vaccinationController.GetRecord(id);
            dateTimePickerDateVac.Value = (DateTime)vaccination[0];
            comboBoxAnimal.SelectedValue = vaccination[1];
            comboBoxDoctor.SelectedValue = vaccination[2];
            comboBoxService.SelectedValue = vaccination[3];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVaccinations.CurrentRow != null)
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
