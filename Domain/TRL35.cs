using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class TRL35
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL35 { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string UrutReporting { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int RumahSakit { get; set; }

        [DefaultValue(0)]
        public int Bidan { get; set; }

        [DefaultValue(0)]
        public int Puskesmas { get; set; }

        [DefaultValue(0)]
        public int FaskesLain { get; set; }

        [DefaultValue(0)]
        public int MedisExit { get; set; }

        [DefaultValue(0)]
        public int MedisTotal { get; set; }

        [DefaultValue(0)]
        public int NonMedisExit { get; set; }

        [DefaultValue(0)]
        public int NonMedisTotal { get; set; }

        [DefaultValue(0)]
        public int NonRujukanExit { get; set; }

        [DefaultValue(0)]
        public int NonRujukanTotal { get; set; }

        [DefaultValue(0)]
        public int Dirujuk { get; set; }

        [DefaultValue(0)]
        public int IsIsi { get; set; }
    }
}
