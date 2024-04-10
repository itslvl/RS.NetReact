using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListReturPembelianDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime TglExpired { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Qty1 { get; set; }
        public decimal Qty2 { get; set; }
        public int IsTerima { get; set; }
        public int KodeReturPembelian { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
    }
}
