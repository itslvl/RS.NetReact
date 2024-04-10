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
    public class RM29
    {
        [Key]
        public int Kode { get; set; }

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

        [DefaultValue(0)]
        public int AnastesiUmum { get; set; }

        [DefaultValue(0)]
        public int Sedasi { get; set; }

        [DefaultValue(0)]
        public int AnastesiSpinal { get; set; }

        [DefaultValue(0)]
        public int AnastesiEpidural { get; set; }

        [DefaultValue(0)]
        public int Kombinasi { get; set; }

        [DefaultValue(0)]
        public int AnastesiKaudal { get; set; }

        [DefaultValue(0)]
        public int BlokSaraf { get; set; }

        [DefaultValue(0)]
        public int LainLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LainLainKeterangan { get; set; }
        
        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SaksiKeluarga { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignSaksiRS { get; set; }
        public string NamaImgSignSaksiPasien { get; set; }


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

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }

        public int KodeNipSaksiRS { get; set; }
        public virtual TPegawai TPegawaiSaksi { get; set; }

        //PK
        public ICollection<RM29Report> LstRM29Report { get; set; }
    }
}
