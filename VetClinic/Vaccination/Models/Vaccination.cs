using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetClinic.animal.Models;
using VetClinic.doctor.Models;
using VetClinic.service.Models;

namespace VetClinic.vaccination.Models
{
    [Table("Vaccination")]
    public partial class Vaccination
    {
        [Key]
        public int id_vaccination { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateVac { get; set; }

        public int? animal_id { get; set; }

        public int? doctor_id { get; set; }

        public int? service_id { get; set; }

        public virtual Animal Animal { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Service Service { get; set; }
    }
}
