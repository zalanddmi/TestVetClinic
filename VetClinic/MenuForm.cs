﻿using System;
using System.Windows.Forms;
using VetClinic.animal.Forms;
using VetClinic.doctor.Forms;
using VetClinic.owner.Forms;
using VetClinic.service.Forms;
using VetClinic.vaccination.Forms;

namespace VetClinic
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm();
            animalForm.ShowDialog();
        }

        private void buttonDoctors_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.ShowDialog();
        }

        private void buttonOwners_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.ShowDialog();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }

        private void buttonVaccinations_Click(object sender, EventArgs e)
        {
            VaccinationForm vaccinationForm = new VaccinationForm();
            vaccinationForm.ShowDialog();
        }
    }
}
