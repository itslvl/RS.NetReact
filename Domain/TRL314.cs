using System;
using System.ComponentModel;

namespace Domain{
    public class TRL314
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeRL314 { get; set; }
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int TerimaPuskesmas { get; set; }

        [DefaultValue(0)]
        public int TerimaFaskes { get; set; }

        [DefaultValue(0)]
        public int TerimaRS { get; set; }

        [DefaultValue(0)]
        public int KembaliPuskemas { get; set; }

        [DefaultValue(0)]
        public int KembaliFaskes { get; set; }

        [DefaultValue(0)]
        public int KembaliRS { get; set; }

        [DefaultValue(0)]
        public int DirujukRujukan { get; set; }

        [DefaultValue(0)]
        public int DirujukDatangSendiri { get; set; }

        [DefaultValue(0)]
        public int DirujukTerimaKembali { get; set; }

    }
}
