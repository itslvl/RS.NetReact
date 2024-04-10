using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM09
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Nama { get; set; }

        public DateTime TglLahir { get; set; }

        public string Alamat { get; set; }

        public string NoTelp { get; set; }

        public string SaksiKeluarga { get; set; }

        public int Deleted { get; set; }

        public string PdfUrl { get; set; }

        //FK
        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeJenisKelamin { get; set; }
        public string UraianJenisKelamin { get; set; }

        public int KodePekerjaan { get; set; }
        public string UraianPekerjaan { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

        public int KodeRegistrasi { get; set; }

        public int KodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public string NamaPemberiInformasi { get; set; }


    }
}
