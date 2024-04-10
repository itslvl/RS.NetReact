using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RKota
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeProvinsi { get; set; }
        public virtual RProvinsi RProvinsi { get; set; }

        //PK
        public ICollection<RKecamatan> LstRKecamatan { get; set; }
    }
}
