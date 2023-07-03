using System;
using System.Collections.Generic;
using VetClinic.interfaces;
using VetClinic.vaccination.Models;
using VetClinic.vaccination.Repositories;

namespace VetClinic.vaccination.Services
{
    public class VaccinationService : IService
    {
        private readonly IRepository<Vaccination> _vaccinationRepository;

        public VaccinationService()
        {
            _vaccinationRepository = new VaccinationRepository();
        }

        public void Add(object[] values)
        {
            DateTime dateVac = (DateTime)values[0];
            int animal_id = (int)values[1];
            int doctor_id = (int)values[2];
            int service_id = (int)values[3];
            Check(dateVac);
            Vaccination vaccination = new Vaccination
            {
                dateVac = dateVac,
                animal_id = animal_id,
                doctor_id = doctor_id,
                service_id = service_id
            };
            _vaccinationRepository.Add(vaccination);
        }

        public void Delete(int id)
        {
            _vaccinationRepository.Delete(id);
        }

        public List<object[]> GetAll()
        {
            var vaccinations = _vaccinationRepository.GetAll();
            var result = new List<object[]>();
            foreach (var vaccination in vaccinations)
            {
                var vaccinationData = new object[]
                {
                    vaccination.id_vaccination,
                    vaccination.dateVac.Value.ToShortDateString(),
                    vaccination.Animal.name,
                    vaccination.Doctor.fio,
                    vaccination.Service.name
                };
                result.Add(vaccinationData);
            }
            return result;
        }

        public object[] GetById(int id)
        {
            var vaccination = _vaccinationRepository.GetById(id) ?? throw new ArgumentException("Данные о выбранной прививке отсутствуют");
            var result = new object[]
            {
                vaccination.dateVac,
                vaccination.animal_id,
                vaccination.doctor_id,
                vaccination.service_id
            };
            return result;
        }

        public void Update(int id, object[] values)
        {
            DateTime dateVac = (DateTime)values[0];
            int animal_id = (int)values[1];
            int doctor_id = (int)values[2];
            int service_id = (int)values[3];
            Check(dateVac);
            Vaccination vaccination = new Vaccination
            {
                dateVac = dateVac,
                animal_id = animal_id,
                doctor_id = doctor_id,
                service_id = service_id
            };
            _vaccinationRepository.Update(id, vaccination);
        }

        private void Check(DateTime dateVac)
        {
            if (dateVac.Date > DateTime.Today)
            {
                throw new ArgumentException("Дата вакцинации не может быть позже текущей.");
            }
        }
    }
}
