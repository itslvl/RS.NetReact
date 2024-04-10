using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM06Obat
    {
        public int Kode { get; set; }

        public string Obat { get; set; }

        public string Dosis { get; set; }

        public string Keterangan { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRM06 { get; set; }

    }
}
