using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM41
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Diagnosa { get; set; }
        
        public DateTime TglOperasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Tindakan { get; set; }

        [DefaultValue(0)]
        public int BlangkoLaporanRuangan { get; set; }

        [DefaultValue(0)]
        public int BlangkoLaporanOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string BlangkoLaporanKeterangan { get; set; }

        [DefaultValue(0)]
        public int BlangkoAnastesiRuangan { get; set; }

        [DefaultValue(0)]
        public int BlangkoAnastesiOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string BlangkoAnastesiKeterangan { get; set; }

        [DefaultValue(0)]
        public int BlangkoImplanRuangan { get; set; }

        [DefaultValue(0)]
        public int BlangkoImplanOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string BlangkoImplanKeterangan { get; set; }

        [DefaultValue(0)]
        public int StatusRuangan { get; set; }

        [DefaultValue(0)]
        public int StatusOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string StatusKeterangan { get; set; }

        [DefaultValue(0)]
        public int RontgenThoraxRuangan { get; set; }

        [DefaultValue(0)]
        public int RontgenThoraxOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string RontgenThoraxKeterangan { get; set; }

        [DefaultValue(0)]
        public int RontgenCtScanRuangan { get; set; }

        [DefaultValue(0)]
        public int RontgenCtScanOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string RontgenCtScanKeterangan { get; set; }

        [DefaultValue(0)]
        public int RontgenMriRuangan { get; set; }

        [DefaultValue(0)]
        public int RontgenMriOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string RontgenMriKeterangan { get; set; }

        [DefaultValue(0)]
        public int RontgenUsgRuangan { get; set; }

        [DefaultValue(0)]
        public int RontgenUsgOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string RontgenUsgKeterangan { get; set; }

        [DefaultValue(0)]
        public int RontgenLainRuangan { get; set; }

        [DefaultValue(0)]
        public int RontgenLainOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string RontgenLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int BarangPasienRuangan { get; set; }

        [DefaultValue(0)]
        public int BarangPasienOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string BarangPasienKeterangan { get; set; }

        [DefaultValue(0)]
        public int VitalSignRuangan { get; set; }

        [DefaultValue(0)]
        public int VitalSignOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string VitalSignKeterangan { get; set; }
        
        public DateTime TglCekTerakhir { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string Nadi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string Suhu { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string Tensi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string Respirasi { get; set; }

        [DefaultValue(0)]
        public int SkalaNyeri { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string BeratBadan { get; set; }

        [DefaultValue(0)]
        public int DrainaseRuangan { get; set; }

        [DefaultValue(0)]
        public int DrainaseOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string DrainaseKeterangan { get; set; }

        [DefaultValue(0)]
        public int DrainaseWsd { get; set; }

        [DefaultValue(0)]
        public int DrainaseRectalTube { get; set; }

        [DefaultValue(0)]
        public int DrainaseDrainLuka { get; set; }

        [DefaultValue(0)]
        public int DrainaseLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string DrainaseLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int IntegrasiRuangan { get; set; }

        [DefaultValue(0)]
        public int IntegrasiOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int IntegrasiLukaTidakAda { get; set; }

        [DefaultValue(0)]
        public int IntegrasiLukaOperasi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaOperasiUkuran { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaOperasiLokasi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaOperasiKondisi { get; set; }

        [DefaultValue(0)]
        public int IntegrasiLukaBakar { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaBakarUkuran { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaBakarLokasi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiLukaBakarKondisi { get; set; }

        [DefaultValue(0)]
        public int IntegrasiKulitMerah { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiKulitMerahUkuran { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiKulitMerahLokasi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IntegrasiKulitMerahKondisi { get; set; }

        [DefaultValue(0)]
        public int LineRuangan { get; set; }

        [DefaultValue(0)]
        public int LineOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string LineKeterangan { get; set; }

        [DefaultValue(0)]
        public int LineTidakAda { get; set; }

        [DefaultValue(0)]
        public int LineIV { get; set; }
        
        public DateTime? LineIvTanggal { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string LineIvPosisi { get; set; }

        [DefaultValue(0)]
        public int LineCVP { get; set; }
        
        public DateTime? LineCvpTanggal { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string LineCvpPosisi { get; set; }

        [DefaultValue(0)]
        public int LineLain { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string LineLainKeterangan { get; set; }
        
        public DateTime? LineLainTanggal { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string LineLainPosisi { get; set; }

        [DefaultValue(0)]
        public int KateterRuangan { get; set; }

        [DefaultValue(0)]
        public int KateterOK { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string KateterKeterangan { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string KateterNomor { get; set; }
        
        public DateTime? KateterTanggal { get; set; }

        [DefaultValue(0)]
        public int IrigasiRuangan { get; set; }

        [DefaultValue(0)]
        public int IrigasiOK { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string IrigasiKeterangan { get; set; }
        
        public DateTime? IrigasiTanggal { get; set; }

        [DefaultValue(0)]
        public int MasalahRuangan { get; set; }

        [DefaultValue(0)]
        public int MasalahOK { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string MasalahKeterangan { get; set; }
        
        public DateTime Tanggal { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPerawatOK { get; set; }
        public string NamaImgSignPerawatRuangan { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeNipPetugasRuangan { get; set; }
        public virtual TPegawai TPegawaiPetugasRuangan { get; set; }

        public int KodeNipPetugasOK { get; set; }
        public virtual TPegawai TPegawaiPetugasOK { get; set; }


        //PK
        public ICollection<RM41Report> LstRM41Report { get; set; }

    }
}
