using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM31
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int AnastesiUmum { get; set; }

        [DefaultValue(0)]
        public int AnastesiSpinal { get; set; }

        [DefaultValue(0)]
        public int BlokPerifer { get; set; }

        [DefaultValue(0)]
        public int Sedasi { get; set; }

        [DefaultValue(0)]
        public int AnastesiTopikal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [DefaultValue(0)]
        public int Umur { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }
        
        public DateTime Tanggal { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }
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

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }


        //PK
        public ICollection<RM31Report> LstRM31Report { get; set; }

    }
}
