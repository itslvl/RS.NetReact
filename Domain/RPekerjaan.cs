using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RPekerjaan
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
        public ICollection<TPasien> LstTPasien { get; set; }
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }

        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }

        [InverseProperty("RPekerjaanAyah")]
        public ICollection<RM13B> LstRM13BPekerjaanAyah { get; set; }
        [InverseProperty("RPekerjaanIbu")]
        public ICollection<RM13B> LstRM13BPekerjaanIbu { get; set; }

        public ICollection<RM58> LstRM58 { get; set; }
    }
}