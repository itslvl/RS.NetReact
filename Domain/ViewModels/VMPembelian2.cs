using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMPembelian2
    {
        public TPembelian TPembelian { get; set; }
        public List<TPembelianDt> ListTPembelianDt { get; set; }
        public TPembelianDt TPembelianDt { get; set; }
        public TPembelianBayar TPembelianBayar { get; set; }
        public List<TPembelianBayar> ListTPembelianBayar { get; set; }
    }
}
