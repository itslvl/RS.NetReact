using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace Domain{
    public class TRL13
    {
        public Guid id { get; set; } = new Guid();
        public int Tahun { get; set; }
        public int KodeRL13 { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int JumlahTT { get; set; }

        [DefaultValue(0)]
        public int KelasVvip { get; set; }

        [DefaultValue(0)]
        public int KelasVip { get; set; }
        
        [DefaultValue(0)]
        public int Kelas1 { get; set; }

        [DefaultValue(0)]
        public int Kelas2 { get; set; }

        [DefaultValue(0)]
        public int Kelas3 { get; set; }

        [DefaultValue(0)]
        public int KelasKhusus { get; set; }

    }
}
