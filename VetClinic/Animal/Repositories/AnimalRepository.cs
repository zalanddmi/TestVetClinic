using System.Collections.Generic;
using System.Linq;
using VetClinic.animal.Models;
using VetClinic.interfaces;
using VetClinic.data;

namespace VetClinic.animal.Repositories
{
    public class AnimalRepository : IRepository<Animal>
    {
        private readonly VetClinicContext _context;

        public AnimalRepository()
        {
            _context = new VetClinicContext();
        }

        public void Add(Animal animal)
        {
            _context.Animal.Add(animal);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var animal = GetById(id);
            if (animal != null)
            {
                _context.Animal.Remove(animal);
                _context.SaveChanges();
            }
        }

        public List<Animal> GetAll()
        {
            return _context.Animal.ToList();
        }

        public Animal GetById(int id)
        {
            return _context.Animal.FirstOrDefault(a => a.id_animal == id);
        }

        public void Update(int id, Animal animal)
        {
            var exAnimal = GetById(id);
            if (exAnimal != null)
            {
                exAnimal.name = animal.name;
                exAnimal.birthDate = animal.birthDate;
                exAnimal.typeAnimal = animal.typeAnimal;
                exAnimal.sex = animal.sex;
                exAnimal.owner_id = animal.owner_id;
            }
            _context.SaveChanges();
        }
    }
}
