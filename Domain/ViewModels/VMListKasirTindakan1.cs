using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListKasirTindakan1
    {
        public int Kode { get; set; }
        public DateTime Tanggal { get; set; }
        public int KodePasien { get; set; }
        public string NamaPasien { get; set; }
        public string NamaDokter { get; set; }
        public string NamaDokterPengirim { get; set; }
        public string Uraian { get; set; }
        public string UraianRuang { get; set; }
        public int NoRequest { get; set; }
        public string UCaraBayar3 {  get; set; }

    }
}
