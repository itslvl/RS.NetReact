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
    public class RM45
    {
        [Key]
        public int Kode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int AlasanPenuh { get; set; }

        [DefaultValue(0)]
        public int AlasanFasilitas { get; set; }

        [DefaultValue(0)]
        public int AlasanPermintaan { get; set; }

        [DefaultValue(0)]
        public int AlasanLain { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlasanLainKeterangan { get; set; }
        
        public DateTime TglStaf1 { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string NoTelpStaf1 { get; set; }
        
        public DateTime TglStaf2 { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string NoTelpStaf2 { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglMasuk { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglKeluar { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NamaPengantar { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelpPengantar { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Anamnese { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Fisik { get; set; }

        [DefaultValue(0)]
        public int AlergiY { get; set; }

        [DefaultValue(0)]
        public int AlergiT { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Alergi { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Penunjang { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Terapi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NamaPenerima { get; set; }

        public DateTime TglSerahTerima { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPerawatPengirim { get; set; }
        public string NamaImgSignPerawatPenerima { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodePendidikanDokter { get; set; }
        public virtual RPendidikan3 RPendidikan3 { get; set; }

        public int KodeRSRujukan { get; set; }
        public virtual RRujukKeluar RRujukKeluar { get; set; }

        public int KodeNipDPJP { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }

        public int KodeNipPerujuk { get; set; }
        public virtual TPegawai TPegawaiPerujuk { get; set; }

        public int KodeNipStaf1 { get; set; }
        public virtual TPegawai TPegawaiStaf1 { get; set; }

        public int KodeRuang31 { get; set; }
        public virtual RRuang3 RRuang31 { get; set; }

        public int KodeNipStaf2 { get; set; }
        public virtual TPegawai TPegawaiStaf2 { get; set; }

        public int KodeRuang32 { get; set; }
        public virtual RRuang3 RRuang32 { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }


        //PK
        //public ICollection<RM45Report> LstRM45Report { get; set; }
    }
}
