using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM39
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Diagnosis { get; set; }

        public string Timing { get; set; }

        public string IndikasiTindakan { get; set; }

        public string RencanaTindakan { get; set; }

        public string ProsedurTindakan { get; set; }

        public string Alternatif { get; set; }

        public string Resiko { get; set; }

        public string Pemantauan { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

    }
}
