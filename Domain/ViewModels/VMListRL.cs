using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRL
    {
        public int Kode { get; set; }
        public int KodePasien { get; set; }
        public int KodeRegistrasi { get; set; }
        public string NamaPasien { get; set; }
        public DateTime TglMasuk { get; set; }
        public string Rawat { get; set; }
        public string Ruang3 { get; set; }
        public int? KodeRawat { get; set; }
        public int KodeCaraBayar { get; set; }
        public string UCaraBayar3 { get; set; }
        public int DPJP { get; set; }
        public string NamaDPJP { get; set; }
    }
}
