using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRadiologiDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public string Keterangan { get; set; }
        public string Kesimpulan { get; set; }
        public int TTindakan2Kode { get; set; }
    }
}
