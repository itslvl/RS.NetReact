using System;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRL37
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public string UrutReporting { get; set; }
        public int KodeRL37 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Jumlah { get; set; }
        public int IsIsi { get; set; }
    }
}
