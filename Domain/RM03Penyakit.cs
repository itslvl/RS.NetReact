using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM03Penyakit
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int PenyebabLangsungYa { get; set; }

        [DefaultValue(0)]
        public int PenyebabLangsungTidak { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Penyebab { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string Interval { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM03 { get; set; }
        public virtual RM03 RM03 { get; set; }

    }
}
