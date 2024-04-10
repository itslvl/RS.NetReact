using System;
using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class SatuSehatOrganization
    {
        //[Key] public int Kode { get; set; }
        public int R1 { get; set; } = 0;
        public int R2 { get; set; } = 0;
        public int R3 { get; set; } = 0;
        public int R4 { get; set; } = 0;
        public int R5 { get; set; } = 0;
        public string Uraian { get; set; } = string.Empty;
        public string SSCode { get; set; } = string.Empty;

    }
}
