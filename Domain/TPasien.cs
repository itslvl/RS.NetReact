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
    public class TPasien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string Nama { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string TempatLahir { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahir { get; set; }

        [DefaultValue("")]
        [MaxLength(1000)]
        public string Alamat { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NoTelp { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string Ayah { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string Ibu { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string Hp { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglKunjungan { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NoId { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string GolDarah { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NIK { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NoKaBpjs { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        public string NikIbu { get; set; } = "";

        [DefaultValue("")]
        [MaxLength(255)]
        public string NoKartuKeluarga { get; set; }

        [DefaultValue("")]
        public string ImageUrl { get; set; }

        [DefaultValue("")]
        public string ImageIdUrl { get; set; }

        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile FileImage { get; set; }

        [Display(Name = "ImageId")]
        [NotMapped]
        public IFormFile FileImageId { get; set; }






        //FK
        [Required]
        public int KodeSuku { get; set; }
        public virtual RSuku RSuku { get; set; }
        [Required]
        public int KodePendidikan { get; set; }
        public virtual RPendidikan RPendidikan { get; set; }
        [Required]
        public int KodeAgama { get; set; }
        public virtual RAgama RAgama { get; set; }
        [Required]
        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }
        [Required]
        public int KodePekerjaan { get; set; }
        public virtual RPekerjaan RPekerjaan { get; set; }
        [Required]
        public int KodePerkawinan { get; set; }
        public virtual RPerkawinan RPerkawinan { get; set; }
        [Required]
        public int KodeId { get; set; }
        public virtual RId RId { get; set; }
        [Required]
        public int KodePerusahaan { get; set; }
        public virtual RPerusahaan RPerusahaan { get; set; }
        [Required]
        public int KodeKelurahan { get; set; }
        public virtual RKelurahan RKelurahan { get; set; }
        [Required]
        public int KodeBahasa { get; set; }
        public virtual RBahasa RBahasa { get; set; }

        //PK
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }
        public ICollection<TRL> LstTRL { get; set; }
        public ICollection<TRL39> LstTRL39 { get; set; }
        public ICollection<TRL310> LstTRL310 { get; set; }
    }
}
