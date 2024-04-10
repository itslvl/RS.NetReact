using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RDTD
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KodeDTD { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian2 { get; set; }

        [MaxLength(6000)]
        [DefaultValue("")]
        [Required]
        public string KodeICD { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Sub { get; set; }
        
        [Required]
        [DefaultValue(0)]
        public int Deleted { get; set; }
        
        [DefaultValue("")]
        [MaxLength(255)]
        [Required]
        public string ShowICD { get; set; }

        //PK
        public ICollection<RICD> LstRICD { get; set; }
    }
}
