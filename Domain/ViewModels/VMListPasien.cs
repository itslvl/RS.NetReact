using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListPasien
    {
        public int Kode { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public DateTime TglLahir { get; set; }
        public string NoKaBpjs { get; set; }
        public string Nik { get; set; }
        public int Deleted { get; set; }
    }
}
