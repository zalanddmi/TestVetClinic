using System.Collections.Generic;
using System.Linq;
using VetClinic.data;
using VetClinic.interfaces;
using VetClinic.service.Models;

namespace VetClinic.service.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        private readonly VetClinicContext _context;

        public ServiceRepository()
        {
            _context = new VetClinicContext();
        }

        public void Add(Service service)
        {
            _context.Service.Add(service);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var service = GetById(id);
            if (service != null)
            {
                _context.Service.Remove(service);
                _context.SaveChanges();
            }
        }

        public List<Service> GetAll()
        {
            return _context.Service.ToList();
        }

        public Service GetById(int id)
        {
            return _context.Service.FirstOrDefault(s => s.id_service == id);
        }

        public void Update(int id, Service service)
        {
            var exService = GetById(id);
            if (exService != null)
            {
                exService.name = service.name;
                exService.description = service.description;
                exService.price = service.price;
            }
            _context.SaveChanges();
        }
    }
}
