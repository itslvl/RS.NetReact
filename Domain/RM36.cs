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
    public class RM36
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string TeknikAnastesi { get; set; }
        
        public DateTime TglOperasi { get; set; }

        [DefaultValue(0)]
        public int ListrikDiatermi { get; set; }

        [DefaultValue(0)]
        public int ListrikSuction { get; set; }

        [DefaultValue(0)]
        public int ListrikHeater { get; set; }

        [DefaultValue(0)]
        public int ListrikGergaji { get; set; }

        [DefaultValue(0)]
        public int ListrikLightSource { get; set; }

        [DefaultValue(0)]
        public int ListrikLightSuction { get; set; }

        [DefaultValue(0)]
        public int ListrikExtension { get; set; }

        [DefaultValue(0)]
        public int ListrikMejaOperasi { get; set; }

        [DefaultValue(0)]
        public int ListrikFilmViewer { get; set; }

        [DefaultValue(0)]
        public int ListrikMikroskop { get; set; }

        [DefaultValue(0)]
        public int ListrikWSD { get; set; }

        [DefaultValue(0)]
        public int ListrikLampuOperasi { get; set; }

        [DefaultValue(0)]
        public int ListrikLampuKamar { get; set; }

        [DefaultValue(0)]
        public int ListrikAC { get; set; }

        [DefaultValue(0)]
        public int AlatTabung { get; set; }

        [DefaultValue(0)]
        public int AlatPatient { get; set; }

        [DefaultValue(0)]
        public int AlatInstrumen { get; set; }

        [DefaultValue(0)]
        public int AlatHandle { get; set; }

        [DefaultValue(0)]
        public int AlatKom { get; set; }

        [DefaultValue(0)]
        public int LinenJas { get; set; }

        [DefaultValue(0)]
        public int LinenDuk { get; set; }

        [DefaultValue(0)]
        public int LinenSarungMeja { get; set; }

        [DefaultValue(0)]
        public int LinenSarungKhaki { get; set; }

        [DefaultValue(0)]
        public int LinenSarungSuction { get; set; }

        [DefaultValue(0)]
        public int AKHP { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignPerawatOK { get; set; }
        public string NamaImgSignKepalaRuanganOK { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeTindakanRM { get; set; }
        public virtual RTindakanRM RTindakanRM { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

        public int KodeNipKepalaRuangan { get; set; }
        public virtual TPegawai TPegawaiKepalaRuangan { get; set; }


        //PK
        public ICollection<RM36Report> LstRM36Report { get; set; }

    }
}
