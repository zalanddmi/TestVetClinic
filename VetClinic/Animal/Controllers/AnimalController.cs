using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.animal.Models;
using VetClinic.animal.Services;
using VetClinic.interfaces;


namespace VetClinic.animal.Controllers
{
    public class AnimalController : IController
    {
        private readonly IService _animalService;

        public AnimalController() 
        {
            _animalService = new AnimalService();
        }

        public void AddRecord(object[] values)
        {
            _animalService.Add(values);
        }

        public void DeleteRecord(int id)
        {
            _animalService.Delete(id);
        }

        public List<object[]> GetAllRecords()
        {
            return _animalService.GetAll();
        }

        public object[] GetRecord(int id)
        {
            return _animalService.GetById(id);
        }

        public void UpdateRecord(int id, object[] values)
        {
            _animalService.Update(id, values);
        }
    }
}
