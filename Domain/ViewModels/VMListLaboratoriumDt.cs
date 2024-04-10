using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListLaboratoriumDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public string Uraian { get; set; }
        public string Satuan { get; set; }
        public string Rujukan { get; set; }
        public string Metode { get; set; }
        public int Grup { get; set; }
        public int IsIsi { get; set; }
        public string Hasil { get; set; }
        public int TTindakan2Kode { get; set; }
        public int RTindakan4Kode { get; set; }
    }
}
