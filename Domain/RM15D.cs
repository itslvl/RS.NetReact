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
    public class RM15D
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime TglKunjungan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Diagnosa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Diet { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string BB { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TB { get; set; }

        [DefaultValue(0)]
        public int AlergiTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiYa { get; set; }

        [DefaultValue(0)]
        public int NutrisiKurangTidak { get; set; }

        [DefaultValue(0)]
        public int NutrisiKurangYa { get; set; }

        [DefaultValue(0)]
        public int NutrisiKurus { get; set; }

        [DefaultValue(0)]
        public int NutrisiMataCekung { get; set; }

        [DefaultValue(0)]
        public int NutrisiWajahCekung { get; set; }

        [DefaultValue(0)]
        public int NutrisiEdema { get; set; }

        [DefaultValue(0)]
        public int NutrisiRambut { get; set; }

        [DefaultValue(0)]
        public int NutrisiOtot { get; set; }

        [DefaultValue(0)]
        public int NutrisiIga { get; set; }

        [DefaultValue(0)]
        public int NutrisiPerut { get; set; }

        [DefaultValue(0)]
        public int NutrisiBokong { get; set; }

        [DefaultValue(0)]
        public int TurunBBTidak { get; set; }

        [DefaultValue(0)]
        public int TurunBBYa { get; set; }

        [DefaultValue(0)]
        public int KondisiTidak { get; set; }

        [DefaultValue(0)]
        public int KondisiYa { get; set; }

        [DefaultValue(0)]
        public int KondisiDiare { get; set; }

        [DefaultValue(0)]
        public int KondisiAsupanMakan { get; set; }

        [DefaultValue(0)]
        public int PenyakitDasarTidak { get; set; }

        [DefaultValue(0)]
        public int PenyakitDasarYa { get; set; }

        [DefaultValue(0)]
        public int PenyakitJantung { get; set; }

        [DefaultValue(0)]
        public int PenyakitBawaan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PenyakitBawaanKeterangan { get; set; }

        [DefaultValue(0)]
        public int PenyakitAkut { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PenyakitAkutKeterangan { get; set; }

        [DefaultValue(0)]
        public int PenyakitHiv { get; set; }

        [DefaultValue(0)]
        public int PenyakitKanker { get; set; }

        [DefaultValue(0)]
        public int PenyakitHati { get; set; }

        [DefaultValue(0)]
        public int PenyakitGinjal { get; set; }

        [DefaultValue(0)]
        public int PenyakitStomaUsus { get; set; }

        [DefaultValue(0)]
        public int PenyakitTrauma { get; set; }

        [DefaultValue(0)]
        public int PenyakitKonstipasi { get; set; }

        [DefaultValue(0)]
        public int PenyakitGagalTumbuh { get; set; }

        [DefaultValue(0)]
        public int PenyakitWajah { get; set; }

        [DefaultValue(0)]
        public int PenyakitMetabolik { get; set; }

        [DefaultValue(0)]
        public int PenyakitRetardasi { get; set; }

        [DefaultValue(0)]
        public int PenyakitPerkembangan { get; set; }

        [DefaultValue(0)]
        public int PenyakitLukaBakar { get; set; }

        [DefaultValue(0)]
        public int PenyakitRencanaOperasi { get; set; }

        [DefaultValue(0)]
        public int PenyakitObesitas { get; set; }

        [DefaultValue(0)]
        public int PenyakitParu { get; set; }

        [DefaultValue(0)]
        public int AlergiTelurYa { get; set; }

        [DefaultValue(0)]
        public int AlergiTelurTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiSusuYa { get; set; }

        [DefaultValue(0)]
        public int AlergiSusuTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiKacangYa { get; set; }

        [DefaultValue(0)]
        public int AlergiKacangTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiGlutenYa { get; set; }

        [DefaultValue(0)]
        public int AlergiGlutenTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiUdangYa { get; set; }

        [DefaultValue(0)]
        public int AlergiUdangTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiIkanYa { get; set; }

        [DefaultValue(0)]
        public int AlergiIkanTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiHazelnutYa { get; set; }

        [DefaultValue(0)]
        public int AlergiHazelnutTidak { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Kesimpulan { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPetugas { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }

        public int KodeNipPenilai { get; set; }
        public virtual TPegawai TPegawaiPenilai { get; set; }


        //PK
        //public ICollection<RM15DReport> LstRM15DReport { get; set; }
    }
}
