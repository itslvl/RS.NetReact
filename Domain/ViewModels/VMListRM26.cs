using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM26
    {
        public int Kode { get; set; }

        public string Suhu { get; set; }

        public string Nadi { get; set; }

        public string RR { get; set; }

        public string TD { get; set; }

        public string SkorNyeri { get; set; }

        public string TB { get; set; }

        public string BB { get; set; }

        public int StatusMentalSadarPenuh { get; set; }

        public int StatusMentalBingung { get; set; }

        public int StatusMentalAgitasi { get; set; }

        public int StatusMentalMengantuk { get; set; }

        public int StatusMentalKoma { get; set; }

        public int RiwayatHipertensi { get; set; }

        public int RiwayatDiabetes { get; set; }

        public int RiwayatHepatitis { get; set; }

        public string RiwayatLainLain { get; set; }

        public string PengobatanSaatIni { get; set; }

        public string AlatBantu { get; set; }

        public string OperasiSebelumnya { get; set; }

        public string OperasiKapan { get; set; }

        public string OperasiDimana { get; set; }

        public int AlergiTidakAda { get; set; }

        public int AlergiTidakDiketahui { get; set; }

        public int AlergiAda { get; set; }

        public string Alergi { get; set; }

        public int HasilLabHB { get; set; }

        public int HasilLabBT { get; set; }

        public int HasilLabCT { get; set; }

        public int HasilLabGolDarah { get; set; }

        public int HasilLabUrine { get; set; }

        public int HasilLab { get; set; }

        public string HasilLabLain { get; set; }

        public int IdentitasPasienRuangan { get; set; }

        public int IdentitasPasienOK { get; set; }

        public string IdentitasPasienKeterangan { get; set; }

        public int GelangIdentitasRuangan { get; set; }

        public int GelangIdentitasOK { get; set; }

        public string GelangIdentitasKeterangan { get; set; }

        public int SpoRuangan { get; set; }

        public int SpoOK { get; set; }

        public string SpoKeterangan { get; set; }

        public int JenisPembedahanRuangan { get; set; }

        public int JenisPembedahanOK { get; set; }

        public string JenisPembedahanKeterangan { get; set; }

        public int KomunikasiRuangan { get; set; }

        public int KomunikasiOK { get; set; }

        public string KomunikasiKeterangan { get; set; }

        public int IzinOperasiRuangan { get; set; }

        public int IzinOperasiOK { get; set; }

        public string IzinOperasiKeterangan { get; set; }

        public int PersetujuanAnestesiRuangan { get; set; }

        public int PersetujuanAnestesiOK { get; set; }

        public string PersetujuanAnestesiKeterangan { get; set; }

        public int ResumeRuangan { get; set; }

        public int ResumeOK { get; set; }

        public string ResumeKeterangan { get; set; }

        public int ScanRuangan { get; set; }

        public int ScanOK { get; set; }

        public string ScanKeterangan { get; set; }

        public int PuasaRuangan { get; set; }

        public int PuasaOK { get; set; }

        public string PuasaKeterangan { get; set; }

        public int ProtheseLuarRuangan { get; set; }

        public int ProtheseLuarOK { get; set; }

        public string ProtheseLuarKeterangan { get; set; }

        public int ProtheseDalamRuangan { get; set; }

        public int ProtheseDalamOK { get; set; }

        public string ProtheseDalamKeterangan { get; set; }

        public int PerhiasanRuangan { get; set; }

        public int PerhiasanOK { get; set; }

        public string PerhiasanKeterangan { get; set; }

        public int KulitRuangan { get; set; }

        public int KulitOK { get; set; }

        public string KulitKeterangan { get; set; }

        public int KandungKemihRuangan { get; set; }

        public int KandungKemihOK { get; set; }

        public string KandungKemihKeterangan { get; set; }

        public int PersiapanDarahRuangan { get; set; }

        public int PersiapanDarahOK { get; set; }

        public string PersiapanDarahKeterangan { get; set; }

        public int AlatBantuRuangan { get; set; }

        public int AlatBantuOK { get; set; }

        public string AlatBantuKeterangan { get; set; }

        public int ObatRuangan { get; set; }

        public int ObatOK { get; set; }

        public string ObatKeterangan { get; set; }

        public int ObatTerakhirRuangan { get; set; }

        public int ObatTerakhirOK { get; set; }

        public string ObatTerakhirKeterangan { get; set; }

        public int VaskulerRuangan { get; set; }

        public int VaskulerOK { get; set; }

        public string VaskulerKeterangan { get; set; }

        public DateTime PeriksaRuangan { get; set; }

        public DateTime PeriksaOK { get; set; }

        public int SiteMarkingYa { get; set; }

        public int SiteMarkingTidak { get; set; }

        public int PenjelasanYa { get; set; }

        public int PenjelasanTidak { get; set; }

        public DateTime TanggalOK2 { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipRuangan { get; set; }
        public string NamaPegawaiRuangan { get; set; }

        public int KodeNipOK { get; set; }
        public string NamaPegawaiOk { get; set; }

        public int KodeNipOK2 { get; set; }
        public string NamaPegawaiOk2 { get; set; }

    }
}
