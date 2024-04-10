using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM15B
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Evaluasi { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeFormulirGizi { get; set; }

        public int KodeNipPetugas { get; set; }
        public string NamaPetugas { get; set; }
    }
}
