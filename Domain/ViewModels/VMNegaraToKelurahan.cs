using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMNegaraToKelurahan
    {
        public int Kode { get; set; }
        public string Uraian { get; set; }
        public string UNegara { get; set; }
        public string UProvinsi { get; set; }
        public string UKota { get; set; }
        public string UKecamatan { get; set; }
        public string UKelurahan { get; set; }
        public int KodeNegara { get; set; }
        public int KodeProvinsi { get; set; }
        public int KodeKota { get; set; }
        public int KodeKecamatan { get; set; }
        public int KodeKelurahan { get; set; }
        public int Deleted { get; set; }
    }
}
