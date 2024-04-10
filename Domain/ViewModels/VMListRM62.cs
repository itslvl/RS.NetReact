using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM62
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Nama { get; set; }

        public int Umur { get; set; }

        public string Alamat { get; set; }

        public string NoId { get; set; }

        public int TujuanTransfusi { get; set; }

        public int ManfaatTransfusi { get; set; }

        public int PerkiraanTransfusi { get; set; }

        public int ResikoTransfusi { get; set; }

        public int AlternatifTransfusi { get; set; }

        public int BiayaTransfusi { get; set; }

        public int TindakanTambahan { get; set; }

        public int TindakanHasil { get; set; }

        public int Setuju { get; set; }

        public int Menolak { get; set; }

        public string NamaSaksiKeluarga { get; set; }

        public int Deleted { get; set; }





        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeJenisKelamin { get; set; }
        public string UraianJenisKelamin { get; set; }

        public int KodeId { get; set; }
        public string UraianId { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

        public int KodeNipDokter { get; set; }
        public string NamaDokter { get; set; }

        public int KodeNipSaksiRS { get; set; }
        public string NamaSaksiRS { get; set; }
    }
}
