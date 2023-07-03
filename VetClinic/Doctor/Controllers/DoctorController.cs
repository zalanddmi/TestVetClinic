using System.Collections.Generic;
using VetClinic.doctor.Services;
using VetClinic.interfaces;

namespace VetClinic.doctor.Controllers
{
    public class DoctorController : IController
    {
        private readonly IService _doctorService;

        public DoctorController()
        {
            _doctorService = new DoctorService();
        }

        public void AddRecord(object[] values)
        {
            _doctorService.Add(values);
        }

        public void DeleteRecord(int id)
        {
            _doctorService.Delete(id);
        }

        public List<object[]> GetAllRecords()
        {
            return _doctorService.GetAll();
        }

        public object[] GetRecord(int id)
        {
            return _doctorService.GetById(id);
        }

        public void UpdateRecord(int id, object[] values)
        {
            _doctorService.Update(id, values);
        }
    }
}
