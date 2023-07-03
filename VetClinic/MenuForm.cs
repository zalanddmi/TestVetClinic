using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.animal.Forms;
using VetClinic.doctor.Forms;
using VetClinic.owner.Forms;

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
    }
}
