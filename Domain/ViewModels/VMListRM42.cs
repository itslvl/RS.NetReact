using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM42
    {
        public int Kode { get; set; }

        public int Pribadi { get; set; }

        public int Asuransi { get; set; }

        public int Perusahaan { get; set; }

        public int Lain { get; set; }

        public string LainKeterangan { get; set; }

        public string TandaTd { get; set; }

        public string TandaN { get; set; }

        public string TandaRR { get; set; }

        public string TandaT { get; set; }

        public int SadarCM { get; set; }

        public int SadarSomnolen { get; set; }

        public int SadarSopor { get; set; }

        public int SadarKoma { get; set; }

        public int LukaOperasiBaik { get; set; }

        public int LukaOperasiAda { get; set; }

        public int LukaLainBekas { get; set; }

        public int LukaLainnya { get; set; }

        public string AldretteScore { get; set; }

        public string Aktivitas { get; set; }

        public string AktivitasKeterangan { get; set; }

        public string Sirkulasi { get; set; }

        public string SirkulasiKeterangan { get; set; }

        public string Pernafasan { get; set; }

        public string PernafasanKeterangan { get; set; }

        public string Kesadaran { get; set; }

        public string KesadaranKeterangan { get; set; }

        public string WarnaKulit { get; set; }

        public string WarnaKulitKeterangan { get; set; }

        public int TotalScore { get; set; }

        public string TerapiKesakitan { get; set; }

        public string TerapiMual { get; set; }

        public string TerapiAntibiotik { get; set; }

        public string TerapiTetes { get; set; }

        public string TerapiObatLain { get; set; }

        public string TerapiInfus { get; set; }

        public string TerapiMinum { get; set; }

        public string Monitoring { get; set; }

        public string Selama { get; set; }

        public string TerapiLain { get; set; }

        public int PaAda { get; set; }

        public int PaTidakAda { get; set; }

        public DateTime Tanggal { get; set; }

        public DateTime Verifikasi { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipPerawatPenerima { get; set; }
        public string NamaPerawatPenerima { get; set; }

        public int KodeNipPerawatRR { get; set; }
        public string NamaPerawatRR { get; set; }

    }
}
