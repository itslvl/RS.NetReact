using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain{
    public class TRL31
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL31 { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Awal { get; set; }

        [DefaultValue(0)]
        public int Masuk { get; set; }

        [DefaultValue(0)]
        public int KeluarHidup { get; set; }

        [DefaultValue(0)]
        public int MatiBawah48Jam { get; set; }

        [DefaultValue(0)]
        public int MatiAtas48Jam { get; set; }

        [DefaultValue(0)]
        public int LamaRawat { get; set; }

        [DefaultValue(0)]
        public int AkhirTahun { get; set; }

        [DefaultValue(0)]
        public int HariRawat { get; set; }

        [DefaultValue(0)]
        public int KelasVVIP { get; set; }

        [DefaultValue(0)]
        public int KelasVIP { get; set; }

        [DefaultValue(0)]
        public int KelasI { get; set; }

        [DefaultValue(0)]
        public int KelasII { get; set; }

        [DefaultValue(0)]
        public int KelasIII { get; set; }

        [DefaultValue(0)]
        public int KelasKhusus { get; set; }

    }
}
