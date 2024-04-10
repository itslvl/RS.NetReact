using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM25
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

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string Hari { get; set; }

        public DateTime TglOperasi { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SaksiPasien { get; set; }

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

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeTindakanRM { get; set; }
        public virtual RTindakanRM RTindakanRM { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public virtual TPegawai TPegawaiDokterOperator { get; set; }

        public int KodeNipSaksiRS { get; set; }
        public virtual TPegawai TPegawaiSaksiRS { get; set; }


        //PK
        public ICollection<RM25Report> LstRM25Report { get; set; }
    }
}
