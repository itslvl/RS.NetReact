using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListResep
    {
        public int Kode { get; set; }
        public DateTime Tanggal { get; set; }
        public string NamaPasien { get; set; }
        public string NamaDokter { get; set; }
        public string Catatan { get; set; }
        public string NamaPerawat { get; set; }
        public string UraianRuang3Pasien { get; set; }
        public string UraianRuang3Farmasi { get; set; }
        public int ReadySend { get; set; }
        public int IsKirim { get; set; }
        public int IsTerima { get; set; }
        public int NoRequest { get; set; }
        public int KodeRuang3 { get; set; }
        public decimal Total { get; set; }
        public decimal TotalKronis { get; set; }


    }
}
