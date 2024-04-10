using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM02
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TempatLahir { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahir { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [DefaultValue(0)]
        public int Biayaumum { get; set; }

        [DefaultValue(0)]
        public int BiayaJKN { get; set; }

        [DefaultValue(0)]
        public int BiayaAsuransi { get; set; }

        [DefaultValue(0)]
        public int BiayaLain { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string BiayaLainKeterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NamaPeserta { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NamaTertanggung { get; set; }

        [DefaultValue(0)]
        public int AsuransiPenuh { get; set; }

        [DefaultValue(0)]
        public int AsuransiPermintaan { get; set; }

        [DefaultValue(0)]
        public int AsuransiLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AsuransiLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int UmumUtama { get; set; }

        [DefaultValue(0)]
        public int UmumVIP { get; set; }

        [DefaultValue(0)]
        public int Umum1 { get; set; }

        [DefaultValue(0)]
        public int Umum2 { get; set; }

        [DefaultValue(0)]
        public int Umum3 { get; set; }

        [DefaultValue(0)]
        public int UmumPenuh { get; set; }

        [DefaultValue(0)]
        public int UmumPermintaan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Saksi1 { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Saksi2 { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignSaksi1 { get; set; }
        public string NamaImgSignSaksi2 { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }
        



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeCaraBayarAsuransi { get; set; }
        public virtual RCaraBayar3 RCaraBayar3 { get; set; }

        public int KodeHakKelasAsuransi { get; set; }
        public virtual RKelasRuang RKelasRuangAsuransi { get; set; }

        public int KodeKelasUmum { get; set; }
        public virtual RKelasRuang RKelasRuangUmum { get; set; }


        //PK
        public ICollection<RM02Informasi> LstRM02Informasi { get; set; }
        public ICollection<RM02Privasi> LstRM02Privasi { get; set; }
        
    }
}
