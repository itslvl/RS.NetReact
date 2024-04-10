using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM24
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaPenerimaInformasi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Diagnosis { get; set; }

        [DefaultValue(0)]
        public int DiagnosisCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string DasarDiagnosis { get; set; }

        [DefaultValue(0)]
        public int DasarDiagnosisCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TindakanKedokteran { get; set; }

        [DefaultValue(0)]
        public int TindakanKedokteranCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string IndikasiTindakan { get; set; }

        [DefaultValue(0)]
        public int IndikasiTindakanCheck { get; set; }
        
        [MaxLength(1000)]
        [DefaultValue("")]
        public string TataCara { get; set; }

        [DefaultValue(0)]
        public int TataCaraCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Tujuan { get; set; }

        [DefaultValue(0)]
        public int TujuanCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Resiko { get; set; }

        [DefaultValue(0)]
        public int ResikoCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Komplikasi { get; set; }

        [DefaultValue(0)]
        public int KomplikasiCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Prognosis { get; set; }

        [DefaultValue(0)]
        public int PrognosisCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Alternatif { get; set; }

        [DefaultValue(0)]
        public int AlternatifCheck { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string HalLain { get; set; }

        [DefaultValue(0)]
        public int HalLainCheck { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglLahirPenerimaInformasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string AlamatPenerimaInformasi { get; set; }

        public DateTime TglTindakan { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Saksi { get; set; }

        [DefaultValue(0)]
        public int Setuju { get; set; }

        [DefaultValue(0)]
        public int TidakSetuju { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignSaksi { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public virtual TPegawai TPegawaiOperator { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public virtual TPegawai TPegawaiPemberiInformasi { get; set; }

        public int KodeTindakanRM { get; set; }
        public virtual RTindakanRM RTIndakanRM { get; set; }

        public int KodeJenisKelaminPenerimaInformasi { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        

        //PK
        public ICollection<RM24Report> LstRM24Report { get; set; }
    }
}
