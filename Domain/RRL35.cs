using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RRL35
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string UrutReporting { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(1)]
        public int IsIsi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }
    }
}
