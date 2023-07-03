using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.data;
using VetClinic.doctor.Models;
using VetClinic.doctor.Repositories;
using VetClinic.interfaces;
using VetClinic.service.Models;
using VetClinic.service.Repositories;

namespace VetClinic.service.Services
{
    public class ServiceService : IService
    {
        private readonly IRepository<Service> _serviceRepository;

        public ServiceService()
        {
            _serviceRepository = new ServiceRepository();
        }

        public void Add(object[] values)
        {
            string name = (string)values[0];
            string description = (string)values[1];
            Check(name, description, values[2]);
            decimal price = Convert.ToDecimal(values[2]);
            Service service = new Service()
            {
                name = name,
                description = description,
                price = price
            };
            _serviceRepository.Add(service);
        }

        public void Delete(int id)
        {
            bool resultCheck = new VetClinicContext().Vaccination.Any(vac => vac.service_id == id);
            if (resultCheck)
            {
                throw new ArgumentException("Данная запись услуги содержится в записях прививок.");
            }
            _serviceRepository.Delete(id);
        }

        public List<object[]> GetAll()
        {
            var services = _serviceRepository.GetAll();
            var result = new List<object[]>();
            foreach (var service in services)
            {
                var serviceData = new object[]
                {
                    service.id_service,
                    service.name,
                    service.description,
                    service.price
                };
                result.Add(serviceData);
            }
            return result;
        }

        public object[] GetById(int id)
        {
            var service = _serviceRepository.GetById(id) ?? throw new ArgumentException("Данные о выбранной услуге отсутствуют");
            var result = new object[]
            {
                service.name,
                service.description,
                service.price
            };
            return result;
        }

        public void Update(int id, object[] values)
        {
            string name = (string)values[0];
            string description = (string)values[1];
            Check(name, description, values[2]);
            decimal price = Convert.ToDecimal(values[2]);
            Service service = new Service()
            {
                name = name,
                description = description,
                price = price
            };
            _serviceRepository.Update(id, service);
        }

        private void Check(string name, string description, object price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Название не может быть пустым.");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Описание не может быть пустой.");
            }
            if (!decimal.TryParse(price.ToString(), out var res) || res < 0)
            {
                throw new ArgumentException("Неверно заполнена стоимость.");
            }
        }
    }
}
