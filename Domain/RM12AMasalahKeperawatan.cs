using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM12AMasalahKeperawatan
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Masalah { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Tujuan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRM12A { get; set; }
        public virtual RM12A RM12A { get; set; }


    }
}
