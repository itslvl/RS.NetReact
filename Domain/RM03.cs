using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM03
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaPenanggungJawab { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string AlamatPenanggungJawab { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoKtpPenanggungJawab { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [DefaultValue(0)]
        public int MasukRJ { get; set; }

        [DefaultValue(0)]
        public int MasukIGD { get; set; }

        [DefaultValue(0)]
        public int CaraBayarUmum { get; set; }

        [DefaultValue(0)]
        public int CaraBayarPerusahaan { get; set; }

        [DefaultValue(0)]
        public int CaraBayarJKN { get; set; }

        [DefaultValue(0)]
        public int JknKis { get; set; }

        [DefaultValue(0)]
        public int JknAsuransi { get; set; }

        [DefaultValue(0)]
        public int JknAskes { get; set; }

        [DefaultValue(0)]
        public int JknTNI { get; set; }

        [DefaultValue(0)]
        public int JknPolri { get; set; }

        [DefaultValue(0)]
        public int JknMandiri { get; set; }

        [DefaultValue(0)]
        public int MasukRujukan { get; set; }

        [DefaultValue(0)]
        public int MasukRujukanRS { get; set; }

        [DefaultValue(0)]
        public int MasukRujukanPuskesmas { get; set; }

        [DefaultValue(0)]
        public int MasukRujukanDr { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MasukRujukanDrKeterangan { get; set; }

        [DefaultValue(0)]
        public int MasukRujukanLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MasukRujukanLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int MasukDatangSendiri { get; set; }

        [DefaultValue(0)]
        public int MasukKasusPolisi { get; set; }

        [DefaultValue(0)]
        public int MasukDiagnosaPengirim { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string MasukDiagnosaPengirimKeterangan { get; set; }

        [DefaultValue(0)]
        public int MasukDiagnosaAwal { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string MasukDiagnosaAwalKeterangan { get; set; }

        public DateTime? TglKeluar { get; set; }

        [DefaultValue(0)]
        public int JumlahHariRawat { get; set; }

        [DefaultValue(0)]
        public int PulangIzinDokter { get; set; }

        [DefaultValue(0)]
        public int PulangPindahRS { get; set; }

        [DefaultValue(0)]
        public int PulangPAPS { get; set; }

        [DefaultValue(0)]
        public int PulangLari { get; set; }

        [DefaultValue(0)]
        public int KondisiPulangSembuh { get; set; }

        [DefaultValue(0)]
        public int KondisiPulangPerbaikan { get; set; }

        [DefaultValue(0)]
        public int KondisiPulangTidakSembuh { get; set; }

        [DefaultValue(0)]
        public int KondisiPulangMeninggalBawah48 { get; set; }

        [DefaultValue(0)]
        public int KondisiPulangMeninggalAtas48 { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaUtama { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TindakanUtama { get; set; }

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

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeKelas { get; set; }
        public virtual RKelasRuang RKelasRuang { get; set; }

        public int KodeMasukRujukanRS { get; set; }
        public virtual RRujukKeluar RRujukKeluar { get; set; }

        public int KodeIcd10 { get; set; }
        public virtual RICD RICD { get; set; }
        
        public int KodeIcd9 { get; set; }
        public virtual RICD9 RICD9 { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }


        //PK
        public ICollection<RM03ICD9> LstRM03ICD9 { get; set; }
        public ICollection<RM03ICD10> LstRM03ICD10 { get; set; }
        public ICollection<RM03Penyakit> LstRM03Penyakit { get; set; }
        public ICollection<RM03Perpindahan> LstRM03Perpindahan { get; set; }
        
    }
}
