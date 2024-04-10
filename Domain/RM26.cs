using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM26
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string Suhu { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string Nadi { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string RR { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string TD { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string SkorNyeri { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string TB { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string BB { get; set; }

        [DefaultValue(0)]
        public int StatusMentalSadarPenuh { get; set; }

        [DefaultValue(0)]
        public int StatusMentalBingung { get; set; }

        [DefaultValue(0)]
        public int StatusMentalAgitasi { get; set; }

        [DefaultValue(0)]
        public int StatusMentalMengantuk { get; set; }

        [DefaultValue(0)]
        public int StatusMentalKoma { get; set; }

        [DefaultValue(0)]
        public int RiwayatHipertensi { get; set; }

        [DefaultValue(0)]
        public int RiwayatDiabetes { get; set; }

        [DefaultValue(0)]
        public int RiwayatHepatitis { get; set; }

        [DefaultValue(0)]
        public int RiwayatLainLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RiwayatLainLainKeterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string PengobatanSaatIni { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlatBantu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string OperasiSebelumnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string OperasiKapan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string OperasiDimana { get; set; }

        [DefaultValue(0)]
        public int AlergiTidakAda { get; set; }

        [DefaultValue(0)]
        public int AlergiTidakDiketahui { get; set; }

        [DefaultValue(0)]
        public int AlergiAda { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Alergi { get; set; }

        [DefaultValue(0)]
        public int HasilLabHB { get; set; }

        [DefaultValue(0)]
        public int HasilLabBT { get; set; }

        [DefaultValue(0)]
        public int HasilLabCT { get; set; }

        [DefaultValue(0)]
        public int HasilLabGolDarah { get; set; }

        [DefaultValue(0)]
        public int HasilLabUrine { get; set; }

        [DefaultValue(0)]
        public int  HasilLab { get; set; }

        [DefaultValue(0)]
        public int HasilLabLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string HasilLabLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int IdentitasPasienRuangan { get; set; }

        [DefaultValue(0)]
        public int IdentitasPasienOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string IdentitasPasienKeterangan { get; set; }

        [DefaultValue(0)]
        public int GelangIdentitasRuangan { get; set; }

        [DefaultValue(0)]
        public int GelangIdentitasOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string GelangIdentitasKeterangan { get; set; }

        [DefaultValue(0)]
        public int SpoRuangan { get; set; }

        [DefaultValue(0)]
        public int SpoOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SpoKeterangan { get; set; }

        [DefaultValue(0)]
        public int JenisPembedahanRuangan { get; set; }

        [DefaultValue(0)]
        public int JenisPembedahanOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string JenisPembedahanKeterangan { get; set; }

        [DefaultValue(0)]
        public int KomunikasiRuangan { get; set; }

        [DefaultValue(0)]
        public int KomunikasiOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KomunikasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int IzinOperasiRuangan { get; set; }

        [DefaultValue(0)]
        public int IzinOperasiOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string IzinOperasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int PersetujuanAnestesiRuangan { get; set; }

        [DefaultValue(0)]
        public int PersetujuanAnestesiOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PersetujuanAnestesiKeterangan { get; set; }

        [DefaultValue(0)]
        public int ResumeRuangan { get; set; }

        [DefaultValue(0)]
        public int ResumeOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ResumeKeterangan { get; set; }

        [DefaultValue(0)]
        public int ScanRuangan { get; set; }

        [DefaultValue(0)]
        public int ScanOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ScanKeterangan { get; set; }

        [DefaultValue(0)]
        public int PuasaRuangan { get; set; }

        [DefaultValue(0)]
        public int PuasaOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PuasaKeterangan { get; set; }

        [DefaultValue(0)]
        public int ProtheseLuarRuangan { get; set; }

        [DefaultValue(0)]
        public int ProtheseLuarOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ProtheseLuarKeterangan { get; set; }

        [DefaultValue(0)]
        public int ProtheseDalamRuangan { get; set; }

        [DefaultValue(0)]
        public int ProtheseDalamOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ProtheseDalamKeterangan { get; set; }

        [DefaultValue(0)]
        public int PerhiasanRuangan { get; set; }

        [DefaultValue(0)]
        public int PerhiasanOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PerhiasanKeterangan { get; set; }

        [DefaultValue(0)]
        public int KulitRuangan { get; set; }

        [DefaultValue(0)]
        public int KulitOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KulitKeterangan { get; set; }

        [DefaultValue(0)]
        public int KandungKemihRuangan { get; set; }

        [DefaultValue(0)]
        public int KandungKemihOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KandungKemihKeterangan { get; set; }

        [DefaultValue(0)]
        public int PersiapanDarahRuangan { get; set; }

        [DefaultValue(0)]
        public int PersiapanDarahOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PersiapanDarahKeterangan { get; set; }

        [DefaultValue(0)]
        public int AlatBantuRuangan { get; set; }

        [DefaultValue(0)]
        public int AlatBantuOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlatBantuKeterangan { get; set; }

        [DefaultValue(0)]
        public int ObatRuangan { get; set; }

        [DefaultValue(0)]
        public int ObatOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ObatKeterangan { get; set; }

        [DefaultValue(0)]
        public int ObatTerakhirRuangan { get; set; }

        [DefaultValue(0)]
        public int ObatTerakhirOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ObatTerakhirKeterangan { get; set; }

        [DefaultValue(0)]
        public int VaskulerRuangan { get; set; }

        [DefaultValue(0)]
        public int VaskulerOK { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string VaskulerKeterangan { get; set; }

        public DateTime PeriksaRuangan { get; set; }

        public DateTime PeriksaOK { get; set; }

        [DefaultValue(0)]
        public int SiteMarkingYa { get; set; }

        [DefaultValue(0)]
        public int SiteMarkingTidak { get; set; }

        [DefaultValue(0)]
        public int PenjelasanYa { get; set; }

        [DefaultValue(0)]
        public int PenjelasanTidak { get; set; }
        
        public DateTime TanggalOK2 { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipRuangan { get; set; }
        public virtual TPegawai TPegawaiRuangan { get; set; }

        public int KodeNipOK { get; set; }
        public virtual TPegawai TPegawaiOK { get; set; }

        public int KodeNipOK2 { get; set; }
        public virtual TPegawai TPegawaiOK2 { get; set; }
        

    }
}
