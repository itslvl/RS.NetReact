using System;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRL312
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL312 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int KonselingANC { get; set; }

        [DefaultValue(0)]
        public int KonselingPascaPersalinan { get; set; }

        [DefaultValue(0)]
        public int CaraMasukBukanRujukan { get; set; }

        [DefaultValue(0)]
        public int CaraMasukRujukanInap { get; set; }

        [DefaultValue(0)]
        public int CaraMasukRujukanJalan { get; set; }

        [DefaultValue(0)]
        public int CaraMasukTotal { get; set; }

        [DefaultValue(0)]
        public int KondisiPascaPersalinan { get; set; }

        [DefaultValue(0)]
        public int KondisiAbortus { get; set; }

        [DefaultValue(0)]
        public int KondisiLainnya { get; set; }

        [DefaultValue(0)]
        public int KunjunganUlang { get; set; }

        [DefaultValue(0)]
        public int EfekSamping { get; set; }

        [DefaultValue(0)]
        public int Dirujuk { get; set; }

    }
}
