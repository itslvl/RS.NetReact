using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListReturResepDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public decimal Harga { get; set; }
        public decimal Kali { get; set; }
        public decimal ResepKali { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Diskon { get; set; }
        public decimal Total { get; set; }
        public decimal Kronis { get; set; }
        public decimal ResepKronis { get; set; }
        public decimal JumlahKronis { get; set; }
        public decimal DiskonKronis { get; set; }
        public decimal TotalKronis { get; set; }
        public int KodeReturResep { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
        public int NIP { get; set; }
        public string UPegawai { get; set; }
    }
}
