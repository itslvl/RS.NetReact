using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListKasirTindakan2
    {
        public int Kode { get; set; }
        public string Uraian { get; set; }
        public decimal Kali { get; set; }
        public decimal Harga1 { get; set; }
        public decimal Jumlah1 { get; set; }
        public decimal Tambah1 { get; set; }
        public decimal Diskon1 { get; set; }
        public decimal Total1 { get; set; }
        public decimal Harga2 { get; set; }
        public decimal Jumlah2 { get; set; }
        public decimal Tambah2 { get; set; }
        public decimal Diskon2 { get; set; }
        public decimal Total2 { get; set; }
        public string UraianRTindakan3 { get; set; }
        public string UraianRRuang3 { get; set; }
        public string NamaDokter { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal TotalAll { get; set; }
    }
}
