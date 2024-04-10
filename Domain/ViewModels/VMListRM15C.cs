using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM15C
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Monitoring { get; set; }

        public string Evaluasi { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeFormulirGizi { get; set; }
    }
}
