using System;
using System.ComponentModel;

namespace Domain{
    public class TRL315
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeCaraBayar1 { get; set; }
        public int KodeCaraBayar2 { get; set; }
        public string UraianCaraBayar1 { get; set; }
        public string UraianCaraBayar2 { get; set; }

        [DefaultValue(0)]
        public int InapKeluar { get; set; }

        [DefaultValue(0)]
        public int InapLamaRawat { get; set; }

        [DefaultValue(0)]
        public int JalanKeluar { get; set; }

        [DefaultValue(0)]
        public int JalanLaboratorium { get; set; }

        [DefaultValue(0)]
        public int JalanRadiologi { get; set; }

        [DefaultValue(0)]
        public int JalanLain { get; set; }
    }
}
