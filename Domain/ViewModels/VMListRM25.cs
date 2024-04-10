using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM25
    {
        public int Kode { get; set; }

        public string Nama { get; set; }

        public int Umur { get; set; }

        public string Alamat { get; set; }

        public string Hari { get; set; }

        public DateTime TglOperasi { get; set; }

        public DateTime Tanggal { get; set; }

        public string SaksiPasien { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

        public int KodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public string NamaDokterOperator { get; set; }

        public int KodeNipSaksiRS { get; set; }
        public string NamaSaksiRs { get; set; }
    }
}
