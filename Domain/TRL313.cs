using System;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRL313
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }

        [DefaultValue(0)]
        public int IsResep { get; set; }
        public int KodeRL313 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int JumlahItem { get; set; }

        [DefaultValue(0)]
        public int JumlahTersedia { get; set; }

        [DefaultValue(0)]
        public int JumlahFormularium { get; set; }
    }
}
