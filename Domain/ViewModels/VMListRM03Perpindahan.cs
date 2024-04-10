using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM03Perpindahan
    {
        public int Kode { get; set; }

        public DateTime TglPindah { get; set; }

        public string TglKeluar { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRuang5 { get; set; }
        public string UraianRuang5 { get; set; }

        public int KodeRL31 { get; set; }
        public string UraianRL31 { get; set; }

        public int KodeRM03 { get; set; }
    }
}
