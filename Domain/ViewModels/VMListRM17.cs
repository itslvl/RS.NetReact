using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM17
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string KeteranganS { get; set; }

        public string KeteranganO { get; set; }

        public string KeteranganA { get; set; }

        public string KeteranganP { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNip { get; set; }
        public string NamaPegawai { get; set; }

        public int KodeJabatan { get; set; }
        public string UraianJabatan { get; set; }

        
        public string UraianRuangan { get; set; }
        public string NamaDpjp { get; set; }

    }
}
