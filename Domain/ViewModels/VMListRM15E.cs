using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM15E
    {
        public int Kode { get; set; }

        public string DiagnosaMedis { get; set; }

        public decimal BB { get; set; }

        public decimal TB { get; set; }

        public decimal IMT { get; set; }

        public decimal TinggiLutut { get; set; }

        public decimal LLA { get; set; }

        public int SkorImt { get; set; }

        public int SkorBB { get; set; }

        public int SkorPenyakit { get; set; }

        public int SkorTotal { get; set; }

        public DateTime Tanggal { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public int KodeNipDietesian { get; set; }
        public string NamaDietesian { get; set; }
    }
}
