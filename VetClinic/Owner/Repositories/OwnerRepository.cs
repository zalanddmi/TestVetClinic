using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.data;
using VetClinic.interfaces;
using VetClinic.owner.Models;

namespace VetClinic.owner.Repositories
{
    public class OwnerRepository : IRepository<Owner>
    {
        private readonly VetClinicContext _context;

        public OwnerRepository()
        {
            _context = new VetClinicContext();
        }

        public void Add(Owner owner)
        {
            _context.Owner.Add(owner);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var owner = GetById(id);
            if (owner != null)
            {
                _context.Owner.Remove(owner);
                _context.SaveChanges();
            }
        }

        public List<Owner> GetAll()
        {
            return _context.Owner.ToList();
        }

        public Owner GetById(int id)
        {
            return _context.Owner.FirstOrDefault(o => o.id_owner == id);
        }

        public void Update(int id, Owner owner)
        {
            var exOwner = GetById(id);
            if (exOwner != null)
            {
                exOwner.fio = owner.fio;
                exOwner.passport = owner.passport;
                exOwner.address = owner.address;
                exOwner.phone = owner.phone;
            }
            _context.SaveChanges();
        }
    }
}
