using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.animal.Models;
using VetClinic.animal.Repositories;
using VetClinic.interfaces;
using VetClinic.owner.Models;
using VetClinic.owner.Repositories;

namespace VetClinic.owner.Services
{
    public class OwnerService : IService
    {
        private readonly IRepository<Owner> _ownerRepository;
        private readonly IRepository<Animal> _animalRepository;

        public OwnerService()
        {
            _ownerRepository = new OwnerRepository();
            _animalRepository = new AnimalRepository();
        }

        public void Add(object[] values)
        {
            string fio = (string)values[0];
            string passport = (string)values[1];
            string address = (string)values[2];
            string phone = (string)values[3];
            Check(fio, passport, address, phone);
            Owner owner = new Owner()
            {
                fio = fio,
                passport = passport,
                address = address,
                phone = phone
            };
            _ownerRepository.Add(owner);
        }

        public void Delete(int id)
        {
            bool resultCheck = _animalRepository.GetAll().Any(a => a.owner_id == id);
            if (resultCheck)
            {
                throw new ArgumentException("Данная запись хозяина содержится в записях животных.");
            }
            _ownerRepository.Delete(id);
        }

        public List<object[]> GetAll()
        {
            var owners = _ownerRepository.GetAll();
            var result = new List<object[]>();
            foreach (var owner in owners)
            {
                var ownerData = new object[]
                {
                    owner.id_owner,
                    owner.fio,
                    owner.passport,
                    owner.address,
                    owner.phone,
                };
                result.Add(ownerData);
            }
            return result;
        }

        public object[] GetById(int id)
        {
            var owner = _ownerRepository.GetById(id) ?? throw new ArgumentException("Данные о выбранном хозяине отсутствуют");
            var result = new object[]
            {
                owner.fio,
                owner.passport,
                owner.address,
                owner.phone,
            };
            return result;
        }

        public void Update(int id, object[] values)
        {
            string fio = (string)values[0];
            string passport = (string)values[1];
            string address = (string)values[2];
            string phone = (string)values[3];
            Check(fio, passport, address, phone);
            Owner owner = new Owner()
            {
                fio = fio,
                passport = passport,
                address = address,
                phone = phone
            };
            _ownerRepository.Update(id, owner);
        }

        private void Check(string fio, string passport, string address, string phone)
        {
            if (string.IsNullOrEmpty(fio))
            {
                throw new ArgumentException("Имя не может быть пустым.");
            }
            if (string.IsNullOrEmpty(passport))
            {
                throw new ArgumentException("Данные паспорта не могут быть пустыми.");
            }
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException("Адрес проживания не может быть пустым.");
            }
            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("Номер телефона не может быть пустым.");
            }
        }
    }
}
