using System.Collections.Generic;
using System.Linq;
using VetClinic.data;
using VetClinic.interfaces;
using VetClinic.vaccination.Models;

namespace VetClinic.vaccination.Repositories
{
    public class VaccinationRepository : IRepository<Vaccination>
    {
        private readonly VetClinicContext _context;

        public VaccinationRepository()
        {
            _context = new VetClinicContext();
        }

        public void Add(Vaccination vaccination)
        {
            _context.Vaccination.Add(vaccination);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var vaccination = GetById(id);
            if (vaccination != null)
            {
                _context.Vaccination.Remove(vaccination);
                _context.SaveChanges();
            }
        }

        public List<Vaccination> GetAll()
        {
            return _context.Vaccination.ToList();
        }

        public Vaccination GetById(int id)
        {
            return _context.Vaccination.FirstOrDefault(vac => vac.id_vaccination == id);
        }

        public void Update(int id, Vaccination vaccination)
        {
            var exVaccination = GetById(id);
            if (exVaccination != null)
            {
                exVaccination.dateVac = vaccination.dateVac;
                exVaccination.animal_id = vaccination.animal_id;
                exVaccination.doctor_id = vaccination.doctor_id;
                exVaccination.service_id = vaccination.service_id;
            }
            _context.SaveChanges();
        }
    }
}
