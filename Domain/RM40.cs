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
    public class RM40
    {
        [Key]
        public int Kode { get; set; }
        

        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int AnastesiUmum { get; set; }

        [DefaultValue(0)]
        public int AnastesiSpinal { get; set; }

        [DefaultValue(0)]
        public int AnastesiEpidural { get; set; }

        [DefaultValue(0)]
        public int AnastesiBSP { get; set; }

        [DefaultValue(0)]
        public int AnastesiCSP { get; set; }

        [DefaultValue(0)]
        public int AnastesiLokal { get; set; }

        [DefaultValue(0)]
        public int SifatEmergensi { get; set; }

        [DefaultValue(0)]
        public int SifatElektif { get; set; }
        
        [DefaultValue(0)]
        public int GolonganMinor { get; set; }

        [DefaultValue(0)]
        public int GolonganMedium { get; set; }

        [DefaultValue(0)]
        public int GolonganMayor { get; set; }

        [DefaultValue(0)]
        public int GolonganKhusus { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string DiagnosisPraBedah { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string DiagnosisPascaBedah { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string IndikasiOperasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string TindakanOperasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string JaringanEksisi { get; set; }

        [DefaultValue(0)]
        public int PaY { get; set; }

        [DefaultValue(0)]
        public int PaT { get; set; }
        
        public DateTime TglMulai { get; set; }
        
        public DateTime TglSelesai { get; set; }

        [MaxLength(20)]
        [DefaultValue("")]
        [Required]
        public string Durasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Komplikasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string JumlahPendarahan { get; set; }

        [DefaultValue(0)]
        public int PascaRuangan { get; set; }

        [DefaultValue(0)]
        public int PascaPicu { get; set; }

        [DefaultValue(0)]
        public int PascaHCU { get; set; }

        [DefaultValue(0)]
        public int PascaRR { get; set; }

        [DefaultValue(0)]
        public int PascaICU { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string PosisiPasien { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Dalam { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Anastesi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Aseptik { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Droping { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Insisi { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Implan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NoRegister { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Instruksi { get; set; }
        
        public DateTime TglSelesaiLaporan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public virtual TPegawai TPegawaiDokterOperator { get; set; }

        public int KodeNipDokterAnastesi { get; set; }
        public virtual TPegawai TPegawaiDokterAnastesi { get; set; }

        public int KodeNipAsistenOperator { get; set; }
        public virtual TPegawai TPegawaiAsistenOperator { get; set; }

        public int KodeNipPerawatAnastesi { get; set; }
        public virtual TPegawai TPegawaiPerawatAnastesi { get; set; }


        //PK
        public ICollection<RM40Report> LstRM40Report { get; set; }

    }
}
