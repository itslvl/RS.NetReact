using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM37
    {
        public int Kode { get; set; }

        public DateTime SignInTgl { get; set; }

        public int SignInIdentitasS { get; set; }

        public int SignInIdentitasB { get; set; }

        public int SignInAreaS { get; set; }

        public int SignInAreaT { get; set; }

        public int SignInMesinS { get; set; }

        public int SignInMesinB { get; set; }

        public int SignInOksimeterS { get; set; }

        public int SignInOksimeterB { get; set; }

        public int SignInRiwayatAlergiY { get; set; }

        public int SignInRiwayatAlergiT { get; set; }

        public string SignInRiwayatKeterangan { get; set; }

        public int SignInJalanNafasY { get; set; }

        public int SignInJalanNafasT { get; set; }

        public int SignInResikoDarahY { get; set; }

        public int SignInResikoDarahT { get; set; }

        public DateTime TimeOutTgl { get; set; }

        public int TimeOutKonfirmasiTimS { get; set; }

        public int TimeOutKonfirmasiTimB { get; set; }

        public int TimeOutKonfirmasiPasienS { get; set; }

        public int TimeOutKonfirmasiPasienB { get; set; }

        public int TimeOutAntibiotikS { get; set; }

        public int TimeOutAntibiotikB { get; set; }

        public int TimeOutAntibiotikT { get; set; }

        public int TimeOutKritisY { get; set; }

        public int TimeOutKritisT { get; set; }

        public string TimeOutKritisKeterangan { get; set; }

        public int TimeOutAntisipasiY { get; set; }

        public int TimeOutAntisipasiT { get; set; }

        public string TimeOutAntisipasiKeterangan { get; set; }

        public int TimeOutKondisiKhususY { get; set; }

        public int TimeOutKondisiKhususT { get; set; }

        public string TimeOutKondisiKhususKeterangan { get; set; }

        public int TimeOutPeralatanSterilY { get; set; }

        public int TimeOutPeralatanSterilT { get; set; }

        public string TimeOutPeralatanSterilKeterangan { get; set; }

        public int TimeOutPeralatanMasalahY { get; set; }

        public int TimeOutPeralatanMasalahT { get; set; }

        public string TimeOutPeralatanMasalahKeterangan { get; set; }

        public int TimeOutFotoS { get; set; }

        public int TimeOutFotoT { get; set; }

        public string LembarKasa { get; set; }

        public DateTime SignOutTgl { get; set; }

        public int SignOutInstrumentY { get; set; }

        public int SignOutInstrumentT { get; set; }

        public int SignOutJumlahKasa { get; set; }

        public int SignOutLebelingY { get; set; }

        public int SignOutLebelingT { get; set; }

        public int SignOutPeralatanY { get; set; }

        public int SignOutPeralatanT { get; set; }

        public string SignOutPeralatanKeterangan { get; set; }

        public int SignOutPentingY { get; set; }

        public int SignOutPentingT { get; set; }

        public string SignOutPentingKeterangan { get; set; }

        public int Deleted { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipPerawatSignIn { get; set; }
        public string NamaPerawatSignIn { get; set; }

        public int KodeNipPerawatTimeOut { get; set; }
        public string NamaPerawatTimeOut { get; set; }

        public int SignOutKodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int SignOutKodeNipDokterAnastesi { get; set; }
        public string NamaDokterAnastesiSignOut { get; set; }

        public int SignOutKodeNipDokterBedah { get; set; }
        public string NamaDokterBedahSignOut { get; set; }

        public int SignOutKodeNipPerawat { get; set; }
        public string NamaPerawatSignOut { get; set; }

    }
}
