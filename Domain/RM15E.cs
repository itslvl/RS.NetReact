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
    public class RM15E
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaMedis { get; set; }

        [DefaultValue(0)]
        public decimal BB { get; set; }

        [DefaultValue(0)]
        public decimal TB { get; set; }

        [DefaultValue(0)]
        public decimal IMT { get; set; }

        [DefaultValue(0)]
        public decimal TinggiLutut { get; set; }

        [DefaultValue(0)]
        public decimal LLA { get; set; }

        [DefaultValue(0)]
        public int SkorImt { get; set; }

        [DefaultValue(0)]
        public int SkorBB { get; set; }

        [DefaultValue(0)]
        public int SkorPenyakit { get; set; }

        [DefaultValue(0)]
        public int SkorTotal { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPetugas { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDietesian { get; set; }
        public virtual TPegawai TPegawai { get; set; }


        //PK
        public ICollection<RM15EReport> LstRM15EReport { get; set; }

    }
}
