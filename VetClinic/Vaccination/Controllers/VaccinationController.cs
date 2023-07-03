using System.Collections.Generic;
using VetClinic.interfaces;
using VetClinic.vaccination.Services;

namespace VetClinic.vaccination.Controllers
{
    public class VaccinationController : IController
    {
        private readonly IService _vaccinationService;

        public VaccinationController()
        {
            _vaccinationService = new VaccinationService();
        }

        public void AddRecord(object[] values)
        {
            _vaccinationService.Add(values);
        }

        public void DeleteRecord(int id)
        {
            _vaccinationService.Delete(id);
        }

        public List<object[]> GetAllRecords()
        {
            return _vaccinationService.GetAll();
        }

        public object[] GetRecord(int id)
        {
            return _vaccinationService.GetById(id);
        }

        public void UpdateRecord(int id, object[] values)
        {
            _vaccinationService.Update(id, values);
        }
    }
}
