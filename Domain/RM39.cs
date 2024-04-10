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
    public class RM39
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Timing { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string IndikasiTindakan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string RencanaTindakan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string ProsedurTindakan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Alternatif { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Resiko { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Pemantauan { get; set; }

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

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }

        //PK
        public ICollection<RM39Report> LstRM39Report { get; set; }

    }
}
