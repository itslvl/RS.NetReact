using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM31
    {
        public int Kode { get; set; }

        public int AnastesiUmum { get; set; }

        public int AnastesiSpinal { get; set; }

        public int BlokPerifer { get; set; }

        public int Sedasi { get; set; }

        public int AnastesiTopikal { get; set; }

        public string Nama { get; set; }

        public int Umur { get; set; }

        public string Alamat { get; set; }

        public string NoTelp { get; set; }

        public DateTime Tanggal { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeJenisKelamin { get; set; }
        public string UraianJenisKelamin { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

    }
}
