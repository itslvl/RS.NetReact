using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM16
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Diagnosa { get; set; }

        public string Tujuan { get; set; }

        public string Intervensi { get; set; }

        public string Implementasi { get; set; }

        public string Evaluasi { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipPerawat { get; set; }
        public string NamaPerawat { get; set; }
        public string UraianRuangan { get; set; }
        public string NamaDpjp { get; set; }
    }
}
