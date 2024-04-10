using System;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRL32
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL32 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Rujukan { get; set; }

        [DefaultValue(0)]
        public int NonRujukan { get; set; }

        [DefaultValue(0)]
        public int Dirawat { get; set; }

        [DefaultValue(0)]
        public int Dirujuk { get; set; }

        [DefaultValue(0)]
        public int Pulang { get; set; }

        [DefaultValue(0)]
        public int IGD { get; set; }

        [DefaultValue(0)]
        public int DOA { get; set; }
    }
}
