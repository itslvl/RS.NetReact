using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListPembelianDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public decimal Jumlah { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal Potongan { get; set; }
        public decimal Total { get; set; }
        public decimal Qty1 { get; set; }
        public decimal Qty2 { get; set; }
        public decimal Modal { get; set; }
        public decimal Diskon { get; set; }
        public decimal PPN { get; set; }
        public decimal PerDiskon { get; set; }
        public decimal PerPPN { get; set; }
        public string BatchNumber { get; set; }
        public int IsTerima { get; set; }
        public int KodePembelian { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
    }
}
