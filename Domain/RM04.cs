using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM04
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string DxMasuk { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Sens { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TD { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Pols { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RR { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Temp { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string TerapiTindakan { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Advis { get; set; }        

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

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
         
        public int KodeNip { get; set; }
        public virtual TPegawai TPegawai { get; set; }



        //PK
        

    }
}
