using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM03Penyakit
    {
        public int Kode { get; set; }

        public int PenyebabLangsungYa { get; set; }

        public int PenyebabLangsungTidak { get; set; }

        public string Penyebab { get; set; }

        public string Interval { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRM03 { get; set; }
    }
}
