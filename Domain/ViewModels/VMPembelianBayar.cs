using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMPembelianBayar
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Bayar { get; set; }
        public int KodePembelian { get; set; }
        public DateTime TglPembelian { get; set; }
        public int KodeSupplier { get; set; }
        public string USupplier { get; set; }
    }
}
