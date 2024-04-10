using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RKecamatan
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Deleted { get; set; }

        //FK
        public int KodeKota { get; set; }
        public virtual RKota RKota { get; set; }

        //PK DI TABLE LAIN
        public ICollection<RKelurahan> LstRKelurahan { get; set; }
    }
}
