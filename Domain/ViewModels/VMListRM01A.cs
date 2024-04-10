using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM01A
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string IsianS { get; set; }

        public string IsianO { get; set; }

        public string IsianA { get; set; }

        public string IsianP { get; set; }

        public string Diagnosa { get; set; }

        public string Keterangan { get; set; }

        public int Deleted { get; set; }
        public string PdfUrl { get; set; }

        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeIcd { get; set; }
        public string KodeICDHuruf { get; set; }
        public string UraianICD { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }
    }
}
