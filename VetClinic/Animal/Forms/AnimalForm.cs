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
using VetClinic.interfaces;

namespace VetClinic.animal.Forms
{
    public partial class AnimalForm : Form
    {
        private readonly IController<Animal> _animalController;

        public AnimalForm()
        {
            InitializeComponent();
            _animalController = new AnimalController();
            ShowRecords();
        }

        private void ShowRecords()
        {
            dataGridViewAnimals.Rows.Clear();
            var records = _animalController.GetAllRecords();
            foreach ( var record in records )
            {
                dataGridViewAnimals.Rows.Add( record ); 
            }
        }
    }
}
