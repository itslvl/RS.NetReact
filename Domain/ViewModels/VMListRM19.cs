using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM19
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Informasi { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipPerawat { get; set; }
        public string NamaPerawat { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

        public int KodeNipPetugas { get; set; }
        public string NamaPetugas { get; set; }


        public string UraianRuangan { get; set; }
        public string NamaDpjp { get; set; }
    }
}
