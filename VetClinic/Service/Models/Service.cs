using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetClinic.vaccination.Models;

namespace VetClinic.service.Models
{
    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Vaccination = new HashSet<Vaccination>();
        }

        [Key]
        public int id_service { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public decimal? price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vaccination> Vaccination { get; set; }
    }
}
