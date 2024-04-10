using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RPendidikan3
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string UrutReporting { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodePendidikan2 { get; set; }
        public virtual RPendidikan2 RPendidikan2 { get; set; }

        //PK
        public ICollection<TPegawai> LstTPegawai { get; set; }

        public ICollection<RM45> LstRM45 { get; set; }
    }
}
