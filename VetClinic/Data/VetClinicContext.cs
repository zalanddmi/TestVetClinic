using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VetClinic.animal.Models;
using VetClinic.doctor.Models;
using VetClinic.owner.Models;
using VetClinic.service.Models;
using VetClinic.vaccination.Models;

namespace VetClinic.data
{
    public partial class VetClinicContext : DbContext
    {
        public VetClinicContext()
            : base("name=Models")
        {
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Vaccination> Vaccination { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Vaccination)
                .WithOptional(e => e.Animal)
                .HasForeignKey(e => e.animal_id);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Vaccination)
                .WithOptional(e => e.Doctor)
                .HasForeignKey(e => e.doctor_id);

            modelBuilder.Entity<Owner>()
                .HasMany(e => e.Animal)
                .WithOptional(e => e.Owner)
                .HasForeignKey(e => e.owner_id);

            modelBuilder.Entity<Service>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Vaccination)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.service_id);
        }
    }
}
