using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMLogistik
    {
        public int Kode { get; set; }
        public string Uraian { get; set; }
        public decimal Harga { get; set; }
        public decimal Modal { get; set; }
        public string UraianRL313 { get; set; }
        public string UraianInaCBG52 { get; set; }
        public string UraianGrupLogistik { get; set; }
        public int Deleted { get; set; }

    }
}