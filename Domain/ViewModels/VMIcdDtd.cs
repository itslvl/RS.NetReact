using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{

    public class VMIcdDtd
    {
        public int Kode { get; set; }
        public string KdICD { get; set; }
        public string Uraian { get; set; }
        //public string Uraian2 { get; set; }
        public int Deleted { get; set; }
        public int IsPenyakit { get; set; }
        public string UraianDTD { get; set; }
    }
}