using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRegistrasiBed
    {
        public int Kode { get; set; }
        public int RegistrasiKode { get; set; }
        public DateTime Tanggal { get; set; }
        public int Ruang5Kode { get; set; }
        public int Ruang3Kode { get; set; }
        public string Ruang { get; set; }
        public string Bed { get; set; }

    }
}
