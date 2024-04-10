using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RKelasRuang
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
        [InverseProperty("RKelasRuangAsuransi")]
        public ICollection<RM02> LstRM02KelasAsuransi { get; set; }
        [InverseProperty("RKelasRuangUmum")]
        public ICollection<RM02> LstRM02KelasUmum { get; set; }
        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RRuang4> LstRuang4 { get; set; }
        
    }
}
