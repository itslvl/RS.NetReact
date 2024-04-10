using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM53
    {
        [Key]
        public int Kode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string DasarDiagnosis { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Terapi { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Prognosis { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string PenerimaInformasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignPemberiInformasi { get; set; }
        public string NamaImgSignPenerimaInformasi { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public virtual TPegawai TPegawaiPemberiInformasi { get; set; }

        //PK
        public ICollection<RM53Report> LstRM53Report { get; set; }

    }
}
