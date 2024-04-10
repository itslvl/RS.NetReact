using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM02Informasi
    {
        public int Kode { get; set; }

        public int MemberiYa { get; set; }

        public int MemberiTidak { get; set; }

        public string Nama { get; set; }

        public int Deleted { get; set; }

        //FK
        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

        public int KodeRM02 { get; set; }
    }
}
