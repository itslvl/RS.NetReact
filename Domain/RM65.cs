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
    public class RM65
    {
        [Key]
        public int Kode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Kepentingan { get; set; }

        [DefaultValue(0)]
        public int SelamaHari { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglAwal { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglAkhir { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NoId { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public string NamaImgSignPasien { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeId { get; set; }
        public virtual RId RId { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }


        //PK
        //public ICollection<RM65Report> LstRM65Report { get; set; }
    }
}
