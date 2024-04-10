using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListPegawai
    {
        public int Kode { get; set; }
        public string NIP { get; set; }
        public string Nama { get; set; }
        public string UraianJabatan { get; set; }
        public int IsFakasi { get; set; }
        public int Deleted { get; set; }

        public int KodePendidikan3 { get; set; }
        public string UraianPendidikan3 { get; set; }
        public int KodePendidikan2 { get; set; }
        public string UraianPendidikan2 { get; set; }
        public string ImageUrl { get; set; }

    }
}
