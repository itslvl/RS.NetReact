using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM30
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }
        
        public DateTime TglOperasi { get; set; }
        
        public DateTime TglTindakan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string TehnikAnastesi { get; set; }

        [DefaultValue(0)]
        public int ListrikMesinAnasthesi { get; set; }

        [DefaultValue(0)]
        public int ListrikLayar { get; set; }

        [DefaultValue(0)]
        public int ListrikSyringe { get; set; }

        [DefaultValue(0)]
        public int ListrikDefibrilator { get; set; }

        [DefaultValue(0)]
        public int GasSelang { get; set; }

        [DefaultValue(0)]
        public int GasFlowO { get; set; }

        [DefaultValue(0)]
        public int GasCompress { get; set; }

        [DefaultValue(0)]
        public int GasFlowAir { get; set; }

        [DefaultValue(0)]
        public int GasNO { get; set; }

        [DefaultValue(0)]
        public int GasFlowNO { get; set; }

        [DefaultValue(0)]
        public int MesinPowerOn { get; set; }

        [DefaultValue(0)]
        public int MesinSelfCollibration { get; set; }

        [DefaultValue(0)]
        public int MesinKebocoran { get; set; }

        [DefaultValue(0)]
        public int MesinZatvolatile { get; set; }

        [DefaultValue(0)]
        public int MesinAbsorber { get; set; }

        [DefaultValue(0)]
        public int NafasSungkup { get; set; }

        [DefaultValue(0)]
        public int NafasOropharygeal { get; set; }

        [DefaultValue(0)]
        public int NafasBatang { get; set; }

        [DefaultValue(0)]
        public int NafasBilah { get; set; }

        [DefaultValue(0)]
        public int NafasGagang { get; set; }

        [DefaultValue(0)]
        public int NafasETT { get; set; }

        [DefaultValue(0)]
        public int NafasStilet { get; set; }

        [DefaultValue(0)]
        public int NafasSemprit { get; set; }

        [DefaultValue(0)]
        public int NafasForceps { get; set; }

        [DefaultValue(0)]
        public int PemantauanKabelEKG { get; set; }

        [DefaultValue(0)]
        public int PemantauanElektrodaEKG { get; set; }

        [DefaultValue(0)]
        public int PemantauanNIBP { get; set; }

        [DefaultValue(0)]
        public int PemantauanSpO { get; set; }

        [DefaultValue(0)]
        public int PemantauanKapnografi { get; set; }

        [DefaultValue(0)]
        public int PemantauanSuhu { get; set; }

        [DefaultValue(0)]
        public int LainStetoskop { get; set; }

        [DefaultValue(0)]
        public int LainSuction { get; set; }

        [DefaultValue(0)]
        public int LainSelang { get; set; }

        [DefaultValue(0)]
        public int LainPlester { get; set; }

        [DefaultValue(0)]
        public int LainLidocaine { get; set; }

        [DefaultValue(0)]
        public int ObatEpinefrin { get; set; }

        [DefaultValue(0)]
        public int ObatAtropin { get; set; }

        [DefaultValue(0)]
        public int ObatSedatif { get; set; }

        [DefaultValue(0)]
        public int ObatOpiat { get; set; }

        [DefaultValue(0)]
        public int ObatPelumpuhOtot { get; set; }
        
        [DefaultValue(0)]
        public int ObatAntiBiotika { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokterAnastesi { get; set; }
        public string NamaImgSignPerawatAnastesi { get; set; }



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

        public int KodeNipPerawatAnastesi { get; set; }
        public virtual TPegawai TPegawaiPerawatAnastesi { get; set; }

        public int KodeNipDokterAnastesi { get; set; }
        public virtual TPegawai TPegawaiDokterAnastesi { get; set; }


        //PK
        public ICollection<RM30Report> LstRM30Report { get; set; }

    }
}
