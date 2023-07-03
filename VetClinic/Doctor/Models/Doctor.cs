using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetClinic.vaccination.Models;

namespace VetClinic.doctor.Models
{
    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Vaccination = new HashSet<Vaccination>();
        }

        [Key]
        public int id_doctor { get; set; }

        [StringLength(50)]
        public string fio { get; set; }

        [StringLength(50)]
        public string specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vaccination> Vaccination { get; set; }
    }
}
