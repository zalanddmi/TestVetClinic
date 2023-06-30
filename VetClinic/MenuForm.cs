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

namespace VetClinic
{
    public partial class MenuForm : Form
    {
        private readonly AnimalForm _animalForm;

        public MenuForm()
        {
            InitializeComponent();
            _animalForm = new AnimalForm();
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            _animalForm.Show();
        }
    }
}
