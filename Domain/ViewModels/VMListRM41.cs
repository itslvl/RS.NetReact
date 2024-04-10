using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM41
    {
        public int Kode { get; set; }

        public string Diagnosa { get; set; }

        public DateTime TglOperasi { get; set; }

        public string Tindakan { get; set; }

        public int BlangkoLaporanRuangan { get; set; }

        public int BlangkoLaporanOK { get; set; }

        public string BlangkoLaporanKeterangan { get; set; }

        public int BlangkoAnastesiRuangan { get; set; }

        public int BlangkoAnastesiOK { get; set; }

        public string BlangkoAnastesiKeterangan { get; set; }

        public int BlangkoImplanRuangan { get; set; }

        public int BlangkoImplanOK { get; set; }

        public string BlangkoImplanKeterangan { get; set; }

        public int StatusRuangan { get; set; }

        public int StatusOK { get; set; }

        public string StatusKeterangan { get; set; }

        public int RontgenThoraxRuangan { get; set; }

        public int RontgenThoraxOK { get; set; }

        public string RontgenThoraxKeterangan { get; set; }

        public int RontgenCtScanRuangan { get; set; }

        public int RontgenCtScanOK { get; set; }

        public string RontgenCtScanKeterangan { get; set; }

        public int RontgenMriRuangan { get; set; }

        public int RontgenMriOK { get; set; }

        public string RontgenMriKeterangan { get; set; }

        public int RontgenUsgRuangan { get; set; }

        public int RontgenUsgOK { get; set; }

        public string RontgenUsgKeterangan { get; set; }

        public int RontgenLainRuangan { get; set; }

        public int RontgenLainOK { get; set; }

        public string RontgenLainKeterangan { get; set; }

        public int BarangPasienRuangan { get; set; }

        public int BarangPasienOK { get; set; }

        public string BarangPasienKeterangan { get; set; }

        public DateTime TglCekTerakhir { get; set; }

        public string Nadi { get; set; }

        public string Suhu { get; set; }

        public string Tensi { get; set; }

        public string Respirasi { get; set; }

        public int SkalaNyeri { get; set; }

        public string BeratBadan { get; set; }

        public int DrainaseRuangan { get; set; }

        public int DrainaseOK { get; set; }

        public string DrainaseKeterangan { get; set; }

        public int DrainaseWsd { get; set; }

        public int DrainaseRectalTube { get; set; }

        public int DrainaseDrainLuka { get; set; }

        public int DrainaseLain { get; set; }

        public int IntegrasiRuangan { get; set; }

        public int IntegrasiOK { get; set; }

        public string IntegrasiKeterangan { get; set; }

        public int IntegrasiLukaTidakAda { get; set; }

        public int IntegrasiLukaOperasi { get; set; }

        public string IntegrasiLukaOperasiUkuran { get; set; }

        public string IntegrasiLukaOperasiLokasi { get; set; }

        public string IntegrasiLukaOperasiKondisi { get; set; }

        public int IntegrasiLukaBakar { get; set; }

        public string IntegrasiLukaBakarUkuran { get; set; }

        public string IntegrasiLukaBakarLokasi { get; set; }

        public string IntegrasiLukaBakarKondisi { get; set; }

        public int IntegrasiKulitMerah { get; set; }

        public string IntegrasiKulitMerahUkuran { get; set; }

        public string IntegrasiKulitMerahLokasi { get; set; }

        public string IntegrasiKulitMerahKondisi { get; set; }

        public int LineRuangan { get; set; }

        public int LineOK { get; set; }

        public string LineKeterangan { get; set; }

        public int LineTidakAda { get; set; }

        public int LineIV { get; set; }

        public DateTime LineIvTanggal { get; set; }

        public string LineIvPosisi { get; set; }

        public int LineCVP { get; set; }

        public DateTime LineCvpTanggal { get; set; }

        public string LineCvpPosisi { get; set; }

        public int LineLain { get; set; }

        public string LineLainKeterangan { get; set; }

        public DateTime LineLainTanggal { get; set; }

        public string LineLainPosisi { get; set; }

        public int KateterRuangan { get; set; }

        public int KateterOK { get; set; }

        public string KateterKeterangan { get; set; }

        public string KateterNomor { get; set; }

        public DateTime KateterTanggal { get; set; }

        public int IrigasiRuangan { get; set; }

        public int IrigasiOK { get; set; }

        public string IrigasiKeterangan { get; set; }

        public DateTime IrigasiTanggal { get; set; }

        public int MasalahRuangan { get; set; }

        public int MasalahOK { get; set; }

        public string MasalahKeterangan { get; set; }

        public DateTime Tanggal { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeNipPetugasRuangan { get; set; }
        public string NamaPetugasRuangan { get; set; }

        public int KodeNipPetugasOK { get; set; }
        public string NamaPetugasOK { get; set; }

    }
}
