using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.doctor.Services;
using VetClinic.interfaces;
using VetClinic.service.Services;

namespace VetClinic.service.Controllers
{
    public class ServiceController : IController
    {
        private readonly IService _serviceService;

        public ServiceController()
        {
            _serviceService = new ServiceService();
        }

        public void AddRecord(object[] values)
        {
            _serviceService.Add(values);
        }

        public void DeleteRecord(int id)
        {
            _serviceService.Delete(id);
        }

        public List<object[]> GetAllRecords()
        {
            return _serviceService.GetAll();
        }

        public object[] GetRecord(int id)
        {
            return _serviceService.GetById(id);
        }

        public void UpdateRecord(int id, object[] values)
        {
            _serviceService.Update(id, values);
        }
    }
}
