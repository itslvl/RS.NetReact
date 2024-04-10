using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RRuang5
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(1)]
        public int IsReady { get; set; }

        [DefaultValue(0)]
        public int IsUse { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Inisial { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        //FK
        public int KodeRuang4 { get; set; }
        public virtual RRuang4 RRuang4 { get; set; }

        //KE TABEL TREGISTRASI
        //PK
        [InverseProperty("RRuang5Bed")]
        public ICollection<TRegistrasi> LstTRegistrasiBed { get; set; }
        [InverseProperty("RRuang5BedAwal")]
        public ICollection<TRegistrasi> LstTRegistrasiBedAwal { get; set; }

        //KE TABLE TREGISTRASIBED
        public ICollection<TRegistrasiBed> LstTRegistrasiBedDT { get; set; }

        public ICollection<RM03Perpindahan> LstRM03Perpindahan { get; set; }
    }
}