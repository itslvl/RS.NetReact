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
    public class RM58
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Hal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Keluhan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Harapan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Pertanyaan { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


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

        public int KodePekerjaan { get; set; }
        public virtual RPekerjaan RPekerjaan { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }


        //PK
        //public ICollection<RM58Report> LstRM58Report { get; set; }

    }
}
