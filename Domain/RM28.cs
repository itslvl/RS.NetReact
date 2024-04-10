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
    public class RM28
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaPenerimaInformasi { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosisKerja { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosisBanding { get; set; }

        [DefaultValue(0)]
        public int TindakanAnastesiUmum { get; set; }

        [DefaultValue(0)]
        public int TindakanSedasi { get; set; }

        [DefaultValue(0)]
        public int TindakanAnastesiSpinal { get; set; }

        [DefaultValue(0)]
        public int TindakanAnastesiEpidural { get; set; }

        [DefaultValue(0)]
        public int TindakanKombinasi { get; set; }

        [DefaultValue(0)]
        public int TindakanAnastesiKaudal { get; set; }

        [DefaultValue(0)]
        public int TindakanBlokSaraf { get; set; }

        [DefaultValue(0)]
        public int TindakanLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TindakanLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int IndikasiKesadaran { get; set; }

        [DefaultValue(0)]
        public int IndikasiNyeri { get; set; }

        [DefaultValue(0)]
        public int IndikasiLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string IndikasiLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int TataCaraPembuluhDarah { get; set; }

        [DefaultValue(0)]
        public int TataCaraJarum { get; set; }

        [DefaultValue(0)]
        public int TataCaraJaringan { get; set; }

        [DefaultValue(0)]
        public int TataCaraLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string TataCaraLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int ResikoNyeriTenggorokan { get; set; }

        [DefaultValue(0)]
        public int ResikoSuara { get; set; }

        [DefaultValue(0)]
        public int ResikoMualMuntah { get; set; }

        [DefaultValue(0)]
        public int ResikoNyeriOtot { get; set; }

        [DefaultValue(0)]
        public int ResikoTrauma { get; set; }

        [DefaultValue(0)]
        public int ResikoAlergi { get; set; }

        [DefaultValue(0)]
        public int ResikoInfeksi { get; set; }

        [DefaultValue(0)]
        public int ResikoPenyempitan { get; set; }

        [DefaultValue(0)]
        public int ResikoJalanNafas { get; set; }

        [DefaultValue(0)]
        public int ResikoPendarahan { get; set; }

        [DefaultValue(0)]
        public int ResikoBekuanDarah { get; set; }

        [DefaultValue(0)]
        public int ResikoAwareness { get; set; }

        [DefaultValue(0)]
        public int ResikoStroke { get; set; }

        [DefaultValue(0)]
        public int ResikoKelumpuhan { get; set; }

        [DefaultValue(0)]
        public int ResikoKematian { get; set; }

        [DefaultValue(0)]
        public int ResikoPenurunanTD { get; set; }

        [DefaultValue(0)]
        public int ResikoPeningkatanTD { get; set; }

        [DefaultValue(0)]
        public int ResikoLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string ResikoLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int KomplikasiLuka { get; set; }

        [DefaultValue(0)]
        public int KomplikasiTrauma { get; set; }

        [DefaultValue(0)]
        public int KomplikasiSakitPunggung { get; set; }

        [DefaultValue(0)]
        public int KomplikasiKerusakanOtak { get; set; }

        [DefaultValue(0)]
        public int KomplikasiKerusakanSaraf { get; set; }

        [DefaultValue(0)]
        public int KomplikasiSeranganJantung { get; set; }

        [DefaultValue(0)]
        public int KomplikasiIramaJantung { get; set; }

        [DefaultValue(0)]
        public int KomplikasiHentiJantung { get; set; }

        [DefaultValue(0)]
        public int KomplikasiLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string KomplikasiLainKeterangan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Prognosis { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Alternatif { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string LainLain { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPasien { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipOperator { get; set; }
        public virtual TPegawai TPegawaiDokterOperator { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public virtual TPegawai TPegawaiInformasi { get; set; }

        public int KodeJabatanPemberiInformasi { get; set; }
        public virtual RJabatan RJabataninformasi { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }


        //PK
        public ICollection<RM28Report> LstRM28Report { get; set; }

    }
}
