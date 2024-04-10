using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM10
    {
        public int Kode { get; set; }

        public string DiagnosaMasuk { get; set; }

        public DateTime TglPindah { get; set; }

        public string DiagnosaSekarang { get; set; }

        public int PasienBpjs { get; set; }

        public int PasienPribadi { get; set; }

        public int PasienAsuransi { get; set; }

        public string KeluhanUtama { get; set; }

        public string RiwayatPenyakit { get; set; }

        public string PemeriksaanFisik { get; set; }

        public string Tensi { get; set; }

        public string Suhu { get; set; }

        public string Nadi { get; set; }

        public string KeadaanUmum { get; set; }

        public string AlasanTransfer { get; set; }

        public string Penunjang { get; set; }

        public string TindakanMedis { get; set; }

        public string TerapiInfus { get; set; }

        public string TerapiInjeksi { get; set; }

        public string TerapiOral { get; set; }

        public string Diet { get; set; }

        public int ResikoJatuhAda { get; set; }

        public int ResikoJatuhTidak { get; set; }

        public int ResikoDekubitusAda { get; set; }

        public int ResikoDekubitusTidak { get; set; }

        public string ResikoDekubitusLokasi { get; set; }

        public string SkalaNyeri { get; set; }

        public int Deleted { get; set; }

        public string PdfUrl { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipDpjp { get; set; }
        public string NamaDpjp { get; set; }

        public int KodeNipKonsulen1 { get; set; }
        public string NamaKonsulen1 { get; set; }

        public int KodeNipKonsulen2 { get; set; }
        public string NamaKonsulen2 { get; set; }

        public int KodeRuang3Awal { get; set; }
        public string UraianRuang3Awal { get; set; }

        public int KodeRuang3Akhir { get; set; }
        public string UraianRuang3Akhir { get; set; }

        public int KodeNipMenyerahkan { get; set; }
        public string NamaPegawaiMenyerahkan { get; set; }

        public int KodeNipMenerima { get; set; }
        public string NamaPegawaiMenerima { get; set; }

    }
}
