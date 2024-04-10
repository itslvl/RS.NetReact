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
    public class RM22
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int AktifitasJenis { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AktifitasJenisKeterangan { get; set; }

        [DefaultValue(0)]
        public int AktifitasProsedur { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AktifitasProsedurKeterangan { get; set; }

        [DefaultValue(0)]
        public int AktifitasAlatBantu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AktifitasAlatBantuKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiJadwal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiJadwalKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiPeriksaLab { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiPeriksaLabKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiEfekObat { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiEfekObatKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiObatAlternatif { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiObatAlternatifKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiKambuh { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiKambuhKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiLainnyaKeterangan { get; set; }

        [DefaultValue(0)]
        public int PerawatanTanda { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PerawatanTandaKeterangan { get; set; }

        [DefaultValue(0)]
        public int PerawatanPengobatan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PerawatanPengobatanKeterangan { get; set; }

        [DefaultValue(0)]
        public int DietAnjuran { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DietAnjuranKeterangan { get; set; }

        [DefaultValue(0)]
        public int DietBatasan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DietBtasanKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaPasien { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaKeluarga { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignKeluargaPasien { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }



        //PK
        public ICollection<RM22JadwalKontrol> LstRM22JadwalKontrol { get; set; }
        public ICollection<RM22Obat> LstRM22Obat { get; set; }
        //public ICollection<RM22Report> LstRM22Report { get; set; }
    }
}
