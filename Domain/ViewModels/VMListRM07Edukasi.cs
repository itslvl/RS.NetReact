using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM07Edukasi
    {
        public int Kode { get; set; }

        public string Edukasi { get; set; }

        public string Media { get; set; }

        public DateTime Tanggal { get; set; }

        public string Metode { get; set; }

        public string TanggalUlang { get; set; }

        public string NamaKeluarga { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRM07 { get; set; }

        public int KodeNipEdukator { get; set; }
        public string NamaEdukator { get; set; }

    }
}
