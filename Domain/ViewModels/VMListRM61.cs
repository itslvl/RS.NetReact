using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM61
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string PotonganTubuh { get; set; }

        public string Hari { get; set; }

        public DateTime TglOperasi { get; set; }

        public string NamaPenerima { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipYangMenyerahkan { get; set; }
        public string NamaYangMenyerahkan { get; set; }

        public int KodeNipDpjp { get; set; }
        public string NamaDPJP { get; set; }
    }
}
