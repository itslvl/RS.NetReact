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
    public class RM42
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string TandaTd { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string TandaN { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string TandaRR { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string TandaT { get; set; }

        [DefaultValue(0)]
        public int SadarCM { get; set; }

        [DefaultValue(0)]
        public int SadarSomnolen { get; set; }

        [DefaultValue(0)]
        public int SadarSopor { get; set; }

        [DefaultValue(0)]
        public int SadarKoma { get; set; }

        [DefaultValue(0)]
        public int LukaOperasiBaik { get; set; }

        [DefaultValue(0)]
        public int LukaOperasiAda { get; set; }

        [DefaultValue(0)]
        public int LukaLainBekas { get; set; }

        [DefaultValue(0)]
        public int LukaLainnya { get; set; }

        [DefaultValue(0)]
        public int Aktivitas { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string AktivitasKeterangan { get; set; }

        [DefaultValue(0)]
        public int Sirkulasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SirkulasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int Pernafasan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string PernafasanKeterangan { get; set; }

        [DefaultValue(0)]
        public int Kesadaran { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KesadaranKeterangan { get; set; }

        [DefaultValue(0)]
        public int WarnaKulit { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string WarnaKulitKeterangan { get; set; }

        [DefaultValue(0)]
        public int TotalScore { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiKesakitan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiMual { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiAntibiotik { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiTetes { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiObatLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiInfus { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TerapiMinum { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Monitoring { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Selama { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string TerapiLain { get; set; }

        [DefaultValue(0)]
        public int PaAda { get; set; }

        [DefaultValue(0)]
        public int PaTidakAda { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPerawatICU { get; set; }
        public string NamaImgSignPerawatRR { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipPerawatPenerima { get; set; }
        public virtual TPegawai TPegawaiPerawatPenerima { get; set; }

        public int KodeNipPerawatRR { get; set; }
        public virtual TPegawai TPegawaiPerawatRR { get; set; }

        //PK
        public ICollection<RM42Report> LstRM42Report { get; set; }

    }
}
