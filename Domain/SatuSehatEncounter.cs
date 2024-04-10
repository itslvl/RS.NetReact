using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class SatuSehatEncounter
    {
        public int Kode { get; set; } = 0;
        public DateTime TglMasuk { get; set; }
        public string Pasien { get; set; } = string.Empty;
        public string PasienSSCode { get; set; } = string.Empty;
        public string Dokter { get; set; } = string.Empty;
        public string DokterSSCode { get; set; } = string.Empty;
        public string Ruang { get; set; } = string.Empty;
        public string RuangSSCode { get; set; } = string.Empty;
        public string SSCode { get; set; } = string.Empty;
    }
}
