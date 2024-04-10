using System;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRL36
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL36 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Total { get; set; }

        [DefaultValue(0)]
        public int Khusus { get; set; }

        [DefaultValue(0)]
        public int Besar { get; set; }

        [DefaultValue(0)]
        public int Sedang { get; set; }

        [DefaultValue(0)]
        public int Kecil { get; set; }
    }
}
