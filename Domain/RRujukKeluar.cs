using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RRujukKeluar
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }

        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM45> LstRM45 { get; set; }
    }
}
