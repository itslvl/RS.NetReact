using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class Setup
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KodeRsOnline { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NamaDirektur { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Provinsi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Kota { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        public string KodePos { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string NoTelp { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Fax { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Email { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Website { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Alamat { get; set; }
        public byte[] Pict { get; set; }
        public byte[] PictDepkes { get; set; }

        [DefaultValue(0)]
        public decimal MinDeposit { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        public string Password { get; set; }

        [DefaultValue(0)]
        public int JumlahBed { get; set; }

        [DefaultValue(0)]
        public int JumlahPenduduk { get; set; }

        [DefaultValue(0)]
        public decimal LimitBudget { get; set; }

        [DefaultValue(0)]
        public int LimitLOS { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string GelangPria { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string GelangWanita { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        public string BPJSId { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string BPJSKey { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        public string BPJSKodeProv { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string BPJSUProv { get; set; }

        public byte[] PictBPJS { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string BPJSUrl { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string AplicaresURL { get; set; }


        public string SsOrganizationId { get; set; }
        public string SsClientKey { get; set; }
        public string SsSecretKey { get; set; }
        public string SsAccessToken { get; set; }






    }
}
