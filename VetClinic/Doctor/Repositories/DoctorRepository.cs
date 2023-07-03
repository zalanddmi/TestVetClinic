using System.Collections.Generic;
using System.Linq;
using VetClinic.data;
using VetClinic.doctor.Models;
using VetClinic.interfaces;

namespace VetClinic.doctor.Repositories
{
    public class DoctorRepository : IRepository<Doctor>
    {
        private readonly VetClinicContext _context;

        public DoctorRepository()
        {
            _context = new VetClinicContext();
        }

        public void Add(Doctor doctor)
        {
            _context.Doctor.Add(doctor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var doctor = GetById(id);
            if (doctor != null)
            {
                _context.Doctor.Remove(doctor);
                _context.SaveChanges();
            }
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctor.ToList();
        }

        public Doctor GetById(int id)
        {
            return _context.Doctor.FirstOrDefault(d => d.id_doctor == id);
        }

        public void Update(int id, Doctor doctor)
        {
            var exDoctor = GetById(id);
            if (exDoctor != null)
            {
                exDoctor.fio = doctor.fio;
                exDoctor.specialization = doctor.specialization;
            }
            _context.SaveChanges();
        }
    }
}
