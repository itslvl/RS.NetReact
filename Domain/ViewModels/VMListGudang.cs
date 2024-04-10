using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListGudang
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public string Uraian { get; set; }
        public decimal Jumlah { get; set; }
        public decimal MinStock { get; set; }
        public int IsOrder { get; set; }
        public int IsShow { get; set; }
        public decimal SaldoAwal { get; set; }
        public DateTime TglTutup { get; set; }
        public int? KodeRuang3 { get; set; }
        public string URuang3 { get; set; }
        public int KodeLogistik { get; set; }
        public string USatuan { get; set; }
    }
}
