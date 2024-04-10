using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM08
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahir { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SaksiKeluarga { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignSaksi { get; set; }
        public string NamaImgSignPetugas { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }

        public int KodePekerjaan { get; set; }
        public virtual RPekerjaan RPekerjaan { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeTindakanRM { get; set; }
        public virtual RTindakanRM RTindakanRM { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public virtual TPegawai TPegawai { get; set; }


        //PK
        public ICollection<RM08Report> LstRM08Report { get; set; }
    }
}
