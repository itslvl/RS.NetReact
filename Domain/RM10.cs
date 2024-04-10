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
    public class RM10
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaMasuk { get; set; }
        
        public DateTime TglPindah { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaSekarang { get; set; }

        [DefaultValue(0)]
        public int PasienBpjs { get; set; }

        [DefaultValue(0)]
        public int PasienPribadi { get; set; }

        [DefaultValue(0)]
        public int PasienAsuransi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string KeluhanUtama { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string RiwayatPenyakit { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PemeriksaanFisik { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Tensi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Suhu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nadi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string KeadaanUmum { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string AlasanTransfer { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Penunjang { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TindakanMedis { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TerapiInfus { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TerapiInjeksi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TerapiOral { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Diet { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhAda { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhTidak { get; set; }

        [DefaultValue(0)]
        public int ResikoDekubitusAda { get; set; }

        [DefaultValue(0)]
        public int ResikoDekubitusTidak { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string ResikoDekubitusLokasi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SkalaNyeri { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignPetugasPenerima { get; set; }
        public string NamaImgSignPetugasPemberi { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }





        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }

        public int KodeNipKonsulen1 { get; set; }
        public virtual TPegawai TPegawaiKonsulen1 { get; set; }

        public int KodeNipKonsulen2 { get; set; }
        public virtual TPegawai TPegawaiKonsulen2 { get; set; }

        public int KodeRuang3Awal { get; set; }
        public virtual RRuang3 RRuang3Awal { get; set; }

        public int KodeRuang3Akhir { get; set; }
        public virtual RRuang3 RRuang3Akhir { get; set; }

        public int KodeNipMenyerahkan { get; set; }
        public virtual TPegawai TPegawaiMenyerahkan { get; set; }

        public int KodeNipMenerima { get; set; }
        public virtual TPegawai TPegawaiMenerima { get; set; }

        
        //PK
        public ICollection<RM10Report> LstRM10Report { get; set; }
    }
}
