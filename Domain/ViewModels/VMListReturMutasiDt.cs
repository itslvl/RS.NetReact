using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListReturMutasiDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Qty1 { get; set; }
        public decimal Qty2 { get; set; }
        public int IsTerima { get; set; }
        public int KodeReturMutasi { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
        public int NIPTerima { get; set; }
        public string UPegawai { get; set; }
    }
}
