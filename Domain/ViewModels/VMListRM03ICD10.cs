using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM03ICD10
    {
        public int Kode { get; set; }

        public string Diagnosa { get; set; }

        public int Deleted { get; set; }

        //FK
        public int KodeRM03 { get; set; }

        public int KodeICD { get; set; }
        public string KodeICD10 { get; set; }
        public string UraianICD10 { get; set; }

    }
}
