using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListLogistikExpired
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public string Catatan { get; set; }
        public int IsTerima { get; set; }
        public int KodeRuang3 { get; set; }
        public string URuang3 { get; set; }
        public int NIPTerima { get; set; }
        public string UPegawai { get; set; }
    }
}
