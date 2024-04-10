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
    public class RM23
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime TglMasuk { get; set; }
        
        public DateTime? TglKeluar { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Riwayat { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string PemeriksaanFisik { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaUtama { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string TindakanUtama { get; set; }

        [DefaultValue(0)]
        public int CaraPulangIzin { get; set; }

        [DefaultValue(0)]
        public int CaraPulangPindah { get; set; }

        [DefaultValue(0)]
        public int CaraPulangPaps { get; set; }

        [DefaultValue(0)]
        public int CaraPulangLari { get; set; }

        [DefaultValue(0)]
        public int KondisiSembuh { get; set; }

        [DefaultValue(0)]
        public int KondisiMembaik { get; set; }

        [DefaultValue(0)]
        public int KondisiBelumSembuh { get; set; }

        [DefaultValue(0)]
        public int KondisiMeninggalKurang48 { get; set; }

        [DefaultValue(0)]
        public int KondisiMeninggalLebih48 { get; set; }

        [DefaultValue(0)]
        public int LanjutPoliklinik { get; set; }

        [DefaultValue(0)]
        public int LanjutPuskesmas { get; set; }

        [DefaultValue(0)]
        public int LanjutRs { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LanjutRsKeterangan { get; set; }

        [DefaultValue(0)]
        public int LanjutDokter { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LanjutDokterKeterangan { get; set; }

        [DefaultValue(0)]
        public int PrognosisAdBonam { get; set; }

        [DefaultValue(0)]
        public int PrognosisAdMalam { get; set; }

        [DefaultValue(0)]
        public int PrognosisDubiaAdBonam { get; set; }

        [DefaultValue(0)]
        public int PrognosisDubiaAdMalam { get; set; }

        public DateTime Tanggal { get; set; }

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

        public int KodeICD10 { get; set; }
        public virtual RICD RICD10 { get; set; }

        public int KodeICD9 { get; set; }
        public virtual RICD9 RICD9 { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDPJP { get; set; }



        //PK
        public ICollection<RM23Tindakan> LstRM23Tindakan { get; set; }
        public ICollection<RM23Diagnosis> LstRM23Diagnosis { get; set; }
        public ICollection<RM23ObatRS> LstRM23ObatRS { get; set; }
        public ICollection<RM23ObatPulang> LstRM23ObatPulang { get; set; }
        public ICollection<RM23Pemeriksaan> LstRM23Pemeriksaan { get; set; }
        //public ICollection<RM23Report> LstRM23Report { get; set; }
    }
}
