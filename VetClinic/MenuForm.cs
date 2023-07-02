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
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm();
            animalForm.ShowDialog();
        }
    }
}
