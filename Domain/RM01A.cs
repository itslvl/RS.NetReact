using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM01A
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime Tanggal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string IsianS { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string IsianO { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string IsianA { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string IsianP { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosa { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Keterangan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public string NamaImgSignDokter { get; set; }
        
        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string PeriksaFisik { get; set; }






        public decimal Nadi { get; set; } = 0;
        public string SSCodeResumeNadi { get; set; } = string.Empty;

        public decimal Pernafasan { get; set; } = 0;
        public string SSCodeResumePernafasan { get; set; } = string.Empty;

        public decimal Sistol { get; set; } = 0;
        public string SSCodeResumeSistol { get; set; } = string.Empty;

        public decimal Diastole { get; set; } = 0;
        public string SSCodeResumeDiastole { get; set; } = string.Empty;

        public decimal Suhu { get; set; } = 0;
        public string SSCodeResumeSuhu { get; set; } = string.Empty;
        public string SSCodeResumeICD9 { get; set; } = string.Empty;
        public string SSCodeResumeICD10 { get; set; } = string.Empty;


        public int IsDiet { get; set; } = 0;
        public string Diet { get; set; } = string.Empty;
        public string SSCodeResumeDiet { get; set; } = string.Empty;

        public int IsFotoThorax { get; set; } = 0;
        public string TujuanFotoThorax { get; set; } = string.Empty;
        public string SSCodeResumeThorax { get; set; } = string.Empty;



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeIcd { get; set; }
        public virtual RICD RICD { get; set; }

        public int KodeIcd9 { get; set; }
        public virtual RICD9 RICD9 { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawai { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }



        //PK
        public ICollection<RM01ADiagnosis> LstRM01ADiagnosis { get; set; }
        public ICollection<RM01ATindakan> LstRM01ATindakan { get; set; }
    }
}
