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
    public class RM05
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        public DateTime Tanggal { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahir { get; set; }

        [DefaultValue(0)]
        public int Umur { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }              
        
        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignPerawat { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeDpjp { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }

        public int KodeNipPetugas { get; set; }
        public virtual TPegawai TPegawaiPetugas { get; set; }

        public int KodeJabatanPetugas { get; set; }
        public virtual RJabatan RJabatan { get; set; }
        
        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }


        //PK
        
    }
}
