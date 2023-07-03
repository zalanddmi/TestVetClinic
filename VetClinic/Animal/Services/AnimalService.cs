using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.animal.Models;
using VetClinic.animal.Repositories;
using VetClinic.data;
using VetClinic.interfaces;
using VetClinic.vaccination.Models;
using VetClinic.vaccination.Repositories;

namespace VetClinic.animal.Services
{
    public class AnimalService : IService
    {
        private readonly IRepository<Animal> _animalRepository;
        private readonly IRepository<Vaccination> _vaccinationRepository;

        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
            _vaccinationRepository = new VaccinationRepository();
        }

        public void Add(object[] values)
        {
            string name = (string)values[0];
            DateTime birthDate = (DateTime)values[1];
            string typeAnimal = (string)values[2];
            bool sex = (int)values[3] == 1;
            int owner_id = (int)values[4];
            Check(name, birthDate, typeAnimal);
            Animal animal = new Animal
            {
                name = name,
                birthDate = birthDate,
                typeAnimal = typeAnimal,
                sex = sex,
                owner_id = owner_id
            };
            _animalRepository.Add(animal);
        }

        public void Delete(int id)
        {
            bool resultCheck = _vaccinationRepository.GetAll().Any(vac => vac.animal_id == id);
            if (resultCheck)
            {
                throw new ArgumentException("Данная запись животного содержится в записях прививок.");
            }
            _animalRepository.Delete(id);
        }

        public List<object[]> GetAll()
        {
            var animals = _animalRepository.GetAll();
            var result = new List<object[]>();
            foreach (var animal in animals )
            {
                var animalData = new object[]
                {
                    animal.id_animal,
                    animal.name,
                    animal.birthDate.Value.ToShortDateString(),
                    animal.typeAnimal,
                    animal.sex == true ? "М" : "Ж",
                    animal.Owner.fio
                };
                result.Add(animalData);
            }
            return result;
        }

        public object[] GetById(int id)
        {
            var animal = _animalRepository.GetById(id) ?? throw new ArgumentException("Данные о выбранном животном отсутствуют");
            var result = new object[]
            {
                animal.name,
                animal.birthDate.Value,
                animal.typeAnimal,
                animal.sex,
                animal.Owner.id_owner
            };
            return result;
        }

        public void Update(int id, object[] values)
        {
            string name = (string)values[0];
            DateTime birthDate = (DateTime)values[1];
            string typeAnimal = (string)values[2];
            bool sex = (int)values[3] == 1;
            int owner_id = (int)values[4];
            Check(name, birthDate, typeAnimal);
            Animal animal = new Animal
            {
                name = name,
                birthDate = birthDate,
                typeAnimal = typeAnimal,
                sex = sex,
                owner_id = owner_id
            };
            _animalRepository.Update(id, animal);
        }

        private void Check(string name, DateTime birthDate, string typeAnimal)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Кличка не может быть пустой.");
            }
            if (birthDate.Date > DateTime.Today)
            {
                throw new ArgumentException("Дата рождения не может быть позже текущей.");
            }
            if (string.IsNullOrWhiteSpace(typeAnimal))
            {
                throw new ArgumentException("Вид животного не может быть пустым.");
            }
        }
    }
}
