using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DotNet.RS.Models
{
    public class TRL12
    {
        public Guid id { get; set; } = new Guid();
        public int Tahun { get; set; }


        public int BedInap { get; set; }
        public int HariRawat { get; set; }
        public int LamaRawat { get; set; }
        public int PasienKeluarHidup { get; set; }
        public int PasienKeluarMati { get; set; }
        public int PasienMatiAtas48 { get; set; }
        public int Poliklinik { get; set; }
        


        [DefaultValue(0)]
        public decimal Bor { get; set; }

        [DefaultValue(0)]
        public decimal Los { get; set; }

        [DefaultValue(0)]
        public decimal Bto { get; set; }

        [DefaultValue(0)]
        public decimal Toi { get; set; }

        [DefaultValue(0)]
        public decimal Ndr { get; set; }

        [DefaultValue(0)]
        public decimal Gdr { get; set; }

        [DefaultValue(0)]
        public decimal Kunjungan { get; set; }

    }
}
