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
    public class RM11
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string KeluhanUtama { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Anamnese { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatPenyakitDahulu { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatPemakaianObat { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatPenyakitKeluarga { get; set; }

        [DefaultValue(0)]
        public int RiwayatPekerjaanY { get; set; }

        [DefaultValue(0)]
        public int RiwayatPekerjaanT { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatPekerjaanKeterangan { get; set; }

        [DefaultValue(0)]
        public int RiwayatAlergiY { get; set; }

        [DefaultValue(0)]
        public int RiwayatAlergiT { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatAlergiMakanan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatAlergiObat { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatAlergiTidakTahu { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatAlergiLainLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string RiwayatAlergiReaksi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Kesadaran { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TekananDarah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Nadi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Suhu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Pernafasan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SkalaNyeri { get; set; }

        [DefaultValue(0)]
        public int KeadaanUmumBaik { get; set; }

        [DefaultValue(0)]
        public int KeadaanUmumSedang { get; set; }

        [DefaultValue(0)]
        public int KeadaanUmumBuruk { get; set; }

        [DefaultValue(0)]
        public int KeadaanGiziBaik { get; set; }

        [DefaultValue(0)]
        public int KeadaanGiziSedang { get; set; }

        [DefaultValue(0)]
        public int KeadaanGiziBuruk { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Oedem { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Ikterus { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Cyanosis { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BB { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TB { get; set; }

        [DefaultValue(0)]
        public int KepalaNormal { get; set; }

        [DefaultValue(0)]
        public int KepalaTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string KepalaNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string KepalaTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int MataNormal { get; set; }

        [DefaultValue(0)]
        public int MataTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MataNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MataTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int ThtNormal { get; set; }

        [DefaultValue(0)]
        public int ThtTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string ThtNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string ThtTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int MulutNormal { get; set; }

        [DefaultValue(0)]
        public int MulutTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MulutNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MulutTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int LeherNormal { get; set; }

        [DefaultValue(0)]
        public int LeherTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string LeherNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string LeherTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int JantungNormal { get; set; }

        [DefaultValue(0)]
        public int JantungTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string JantungNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string JantungTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int ParuNormal { get; set; }

        [DefaultValue(0)]
        public int ParuTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string ParuNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string ParuTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int DadaNormal { get; set; }

        [DefaultValue(0)]
        public int DadaTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string DadaNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string DadaTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int PerutNormal { get; set; }

        [DefaultValue(0)]
        public int PerutTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string PerutNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string PerutTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int UrogenitalNormal { get; set; }

        [DefaultValue(0)]
        public int UrogenitalTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string UrogenitalNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string UrogenitalTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int AnggotaGerakNormal { get; set; }

        [DefaultValue(0)]
        public int AnggotaGerakTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AnggotaGerakNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AnggotaGerakTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int StatusNeuroNormal { get; set; }

        [DefaultValue(0)]
        public int StatusNeuroTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string StatusNeuroNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string StatusNeuroTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int MuskuloskeletalNormal { get; set; }

        [DefaultValue(0)]
        public int MuskuloskeletalTidakNormal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MuskuloskeletalNormalKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string MuskuloskeletalTidakNormalKeterangan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string PemeriksaanPenunjang { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string Diagnosa { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string Pengobatan { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string Rencana { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }


        //PK
        //public ICollection<RM11Report> LstRM11Report { get; set; }
    }
}
