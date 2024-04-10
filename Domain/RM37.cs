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
    public class RM37
    {
        [Key]
        public int Kode { get; set; }
        

        public DateTime SignInTgl { get; set; }

        [DefaultValue(0)]
        public int SignInIdentitasS { get; set; }

        [DefaultValue(0)]
        public int SignInIdentitasB { get; set; }

        [DefaultValue(0)]
        public int SignInAreaS { get; set; }

        [DefaultValue(0)]
        public int SignInAreaT { get; set; }

        [DefaultValue(0)]
        public int SignInMesinS { get; set; }

        [DefaultValue(0)]
        public int SignInMesinB { get; set; }

        [DefaultValue(0)]
        public int SignInOksimeterS { get; set; }

        [DefaultValue(0)]
        public int SignInOksimeterB { get; set; }

        [DefaultValue(0)]
        public int SignInRiwayatAlergiY { get; set; }

        [DefaultValue(0)]
        public int SignInRiwayatAlergiT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SignInRiwayatKeterangan { get; set; }

        [DefaultValue(0)]
        public int SignInJalanNafasY { get; set; }

        [DefaultValue(0)]
        public int SignInJalanNafasT { get; set; }

        [DefaultValue(0)]
        public int SignInResikoDarahY { get; set; }

        [DefaultValue(0)]
        public int SignInResikoDarahT { get; set; }
        
        public DateTime TimeOutTgl { get; set; }

        [DefaultValue(0)]
        public int TimeOutKonfirmasiTimS { get; set; }

        [DefaultValue(0)]
        public int TimeOutKonfirmasiTimB { get; set; }

        [DefaultValue(0)]
        public int TimeOutKonfirmasiPasienS { get; set; }

        [DefaultValue(0)]
        public int TimeOutKonfirmasiPasienB { get; set; }

        [DefaultValue(0)]
        public int TimeOutAntibiotikS { get; set; }

        [DefaultValue(0)]
        public int TimeOutAntibiotikB { get; set; }

        [DefaultValue(0)]
        public int TimeOutAntibiotikT { get; set; }

        [DefaultValue(0)]
        public int TimeOutKritisY { get; set; }

        [DefaultValue(0)]
        public int TimeOutKritisT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TimeOutKritisKeterangan { get; set; }

        [DefaultValue(0)]
        public int TimeOutAntisipasiY { get; set; }

        [DefaultValue(0)]
        public int TimeOutAntisipasiT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TimeOutAntisipasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int TimeOutKondisiKhususY { get; set; }

        [DefaultValue(0)]
        public int TimeOutKondisiKhususT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TimeOutKondisiKhususKeterangan { get; set; }

        [DefaultValue(0)]
        public int TimeOutPeralatanSterilY { get; set; }

        [DefaultValue(0)]
        public int TimeOutPeralatanSterilT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TimeOutPeralatanSterilKeterangan { get; set; }

        [DefaultValue(0)]
        public int TimeOutPeralatanMasalahY { get; set; }

        [DefaultValue(0)]
        public int TimeOutPeralatanMasalahT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TimeOutPeralatanMasalahKeterangan { get; set; }

        [DefaultValue(0)]
        public int TimeOutFotoS { get; set; }

        [DefaultValue(0)]
        public int TimeOutFotoT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LembarKasa { get; set; }
        
        public DateTime SignOutTgl { get; set; }        

        [DefaultValue(0)]
        public int SignOutInstrumentY { get; set; }

        [DefaultValue(0)]
        public int SignOutInstrumentT { get; set; }

        [DefaultValue(0)]
        public int SignOutJumlahKasa { get; set; }

        [DefaultValue(0)]
        public int SignOutLebelingY { get; set; }

        [DefaultValue(0)]
        public int SignOutLebelingT { get; set; }

        [DefaultValue(0)]
        public int SignOutPeralatanY { get; set; }

        [DefaultValue(0)]
        public int SignOutPeralatanT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SignOutPeralatanKeterangan { get; set; }

        [DefaultValue(0)]
        public int SignOutPentingY { get; set; }

        [DefaultValue(0)]
        public int SignOutPentingT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string SignOutPentingKeterangan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignInPerawat { get; set; }
        public string NamaImgSignTimeOutPerawat { get; set; }
        public string NamaImgSignOutPerawat { get; set; }
        public string NamaImgSignOutDokterBedah { get; set; }
        public string NamaImgSignOutDokterAnastesi { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
        
        public int KodeNipPerawatSignIn { get; set; }
        public virtual TPegawai TPegawaiPerawatSignIn { get; set; }

        public int KodeNipPerawatTimeOut { get; set; }
        public virtual TPegawai TPegawaiPerawatTimeOut { get; set; }

        public int SignOutKodeTindakanRM { get; set; }
        public virtual RTindakanRM RTindakanRM { get; set; }

        public int SignOutKodeNipDokterAnastesi { get; set; }
        public virtual TPegawai TPegawaiDokterAnastesiSignOut { get; set; }

        public int SignOutKodeNipDokterBedah { get; set; }
        public virtual TPegawai TPegawaiDokterBedahSignOut { get; set; }

        public int SignOutKodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawatSignOut { get; set; }

        //PK
        public ICollection<RM37Report> LstRM37Report { get; set; }
    }
}
