using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetClinic.animal.Models;

namespace VetClinic.owner.Models
{
    [Table("Owner")]
    public partial class Owner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Owner()
        {
            Animal = new HashSet<Animal>();
        }

        [Key]
        public int id_owner { get; set; }

        [StringLength(50)]
        public string fio { get; set; }

        [StringLength(20)]
        public string passport { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animal { get; set; }
    }
}
