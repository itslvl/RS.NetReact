using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM29
    {
        public int Kode { get; set; }

        public string Nama { get; set; }

        public int Umur { get; set; }

        public string Alamat { get; set; }

        public int AnastesiUmum { get; set; }

        public int Sedasi { get; set; }

        public int AnastesiSpinal { get; set; }

        public int AnastesiEpidural { get; set; }

        public int Kombinasi { get; set; }

        public int AnastesiKaudal { get; set; }

        public int BlokSaraf { get; set; }

        public int LainLain { get; set; }

        public string LainLainKeterangan { get; set; }

        public DateTime Tanggal { get; set; }

        public string SaksiKeluarga { get; set; }

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
        public string NamaSaksiRs { get; set; }

    }
}
