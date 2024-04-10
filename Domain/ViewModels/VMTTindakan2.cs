using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMTTindakan2
    {
        public int Kode { get; set; }
        public int TTindakan1Kode { get; set; }
        public int RTindakan3Kode { get; set; }
        public string RTindakan3Uraian { get; set; }
        [DefaultValue(0)]
        public decimal Kali { get; set; }
        [DefaultValue(0)]
        public decimal Harga1 { get; set; }
        [DefaultValue(0)]
        public decimal Tambah1 { get; set; }
        public decimal? Jumlah1
        {
            get { return ((Kali * Harga1) + Tambah1); }
            set { }
        }
        [DefaultValue(0)]
        public decimal Diskon1 { get; set; }
        public decimal? Total1
        {
            get { return ((Kali * Harga1) + Tambah1 - Diskon1); }
            set { }
        }
        [DefaultValue(0)]
        public decimal Harga2 { get; set; }
        [DefaultValue(0)]
        public decimal Tambah2 { get; set; }
        public decimal? Jumlah2
        {
            get { return ((Kali * Harga2) + Tambah2); }
            set { }
        }
        [DefaultValue(0)]
        public decimal Diskon2 { get; set; }
        public decimal? Total2
        {
            get { return ((Kali * Harga2) + Tambah2 - Diskon1); }
            set { }
        }

    }
}
