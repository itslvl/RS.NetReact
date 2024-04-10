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
    public class RM46
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Perawatan { get; set; }

        [DefaultValue(0)]
        public int Pengobatan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Keluarga { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SaksiKeluarga { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignSaksi { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        //PK
        //public ICollection<RM46Report> LstRM46Report { get; set; }
    }
}
