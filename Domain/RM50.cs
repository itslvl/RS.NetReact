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
    public class RM50
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TempatLahir { get; set; }

        [DataType(DataType.Date)]
        public DateTime TanggalLahir { get; set; }

        [DefaultValue(0)]
        public int Umur { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [DefaultValue(0)]
        public int BukuDoaY { get; set; }

        [DefaultValue(0)]
        public int BukuDoaT { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignPerawat { get; set; }
        public string NamaImgSignPasien { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeHubunganDenganPasien { get; set; }
        public virtual RHubunganKeluarga RHubunganDenganPasien { get; set; }

        public int KodeAgama { get; set; }
        public virtual RAgama RAgama { get; set; }

        public int KodeNipKepalaRuangan { get; set; }
        public virtual TPegawai TPegawaiKepalaRuangan { get; set; }



        //PK
        //public ICollection<RM50Report> LstRM50Report { get; set; }

    }
}
