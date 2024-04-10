using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM56
    {
        public int Kode { get; set; }

        public string Nama { get; set; }

        public DateTime TglLahir { get; set; }

        public int Umur { get; set; }

        public string Alamat { get; set; }

        public string Pengobatan { get; set; }

        public string Tindakan { get; set; }

        public string SaksiPasien { get; set; }

        public DateTime Tanggal { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeJenisKelamin { get; set; }
        public string UraianJenisKelamin { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

        public int KodeNipSaksiRS { get; set; }
        public string NamaSaksiRS { get; set; }
    }
}
