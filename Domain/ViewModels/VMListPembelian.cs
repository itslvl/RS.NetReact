using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListPembelian
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public string NoFaktur { get; set; }
        public DateTime TglFaktur { get; set; }
        public string Catatan { get; set; }
        public int IsTerima { get; set; }
        public int KodeRuang3 { get; set; }
        public string URuang3 { get; set; }
        public int KodeSupplier { get; set; }
        public string USupplier { get; set; }
        public int NipTerima { get; set; }
        public string NamaTerima { get; set; }
        public int ApproveBy { get; set; }
        public string NamaApprove { get; set; }
        public string ApproveSign { get; set; }
    }
}
