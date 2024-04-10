using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM56
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahir { get; set; }

        [DefaultValue(0)]
        public int Umur { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Pengobatan { get; set; }
        
        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Tindakan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SaksiPasien { get; set; }
        
        public DateTime Tanggal { get; set; }

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
        public virtual TPegawai TPegawaiSaksiRS { get; set; }


        //PK
        public ICollection<RM56Report> LstRM56Report { get; set; }

    }
}
