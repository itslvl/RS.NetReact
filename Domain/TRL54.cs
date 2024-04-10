using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class TRL54
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeIcd { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KodeIcdShow { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int KasusL { get; set; }

        [DefaultValue(0)]
        public int KasusP { get; set; }

        [DefaultValue(0)]
        public int JumlahKunjungan { get; set; }
    }
}
