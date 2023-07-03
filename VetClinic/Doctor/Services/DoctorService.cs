using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.animal.Repositories;
using VetClinic.data;
using VetClinic.doctor.Models;
using VetClinic.doctor.Repositories;
using VetClinic.interfaces;
using VetClinic.vaccination.Models;
using VetClinic.vaccination.Repositories;

namespace VetClinic.doctor.Services
{
    public class DoctorService : IService
    {
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IRepository<Vaccination> _vaccinationRepository;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
            _vaccinationRepository = new VaccinationRepository();
        }

        public void Add(object[] values)
        {
            string fio = (string)values[0];
            string specialization = (string)values[1];
            Check(fio, specialization);
            Doctor doctor = new Doctor
            {
                fio = fio,
                specialization = specialization
            };
            _doctorRepository.Add(doctor);
        }

        public void Delete(int id)
        {
            bool resultCheck = _vaccinationRepository.GetAll().Any(vac => vac.doctor_id == id);
            if (resultCheck)
            {
                throw new ArgumentException("Данная запись врача содержится в записях прививок.");
            }
            _doctorRepository.Delete(id);
        }

        public List<object[]> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            var result = new List<object[]>();
            foreach (var doctor in doctors)
            {
                var doctorData = new object[]
                {
                    doctor.id_doctor,
                    doctor.fio,
                    doctor.specialization
                };
                result.Add(doctorData);
            }
            return result;
        }

        public object[] GetById(int id)
        {
            var doctor = _doctorRepository.GetById(id) ?? throw new ArgumentException("Данные о выбранном враче отсутствуют");
            var result = new object[]
            {
                doctor.fio,
                doctor.specialization
            };
            return result;
        }

        public void Update(int id, object[] values)
        {
            string fio = (string)values[0];
            string specialization = (string)values[1];
            Check(fio, specialization);
            Doctor doctor = new Doctor
            {
                fio = fio,
                specialization = specialization
            };
            _doctorRepository.Update(id, doctor);
        }

        private void Check(string fio, string specialization)
        {
            if (string.IsNullOrEmpty(fio))
            {
                throw new ArgumentException("Имя не может быть пустым.");
            }
            if (string.IsNullOrEmpty(specialization))
            {
                throw new ArgumentException("Специализация не может быть пустой.");
            }
        }
    }
}
