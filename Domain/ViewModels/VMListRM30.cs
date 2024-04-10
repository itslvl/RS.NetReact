using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM30
    {
        public int Kode { get; set; }

        public string Diagnosis { get; set; }

        public DateTime TglOperasi { get; set; }

        public DateTime TglTindakan { get; set; }

        public string TehnikAnastesi { get; set; }

        public int ListrikMesinAnasthesi { get; set; }

        public int ListrikLayar { get; set; }

        public int ListrikSyringe { get; set; }

        public int ListrikDefibrilator { get; set; }

        public int GasSelang { get; set; }

        public int GasFlowO { get; set; }

        public int GasCompress { get; set; }

        public int GasFlowAir { get; set; }

        public int GasNO { get; set; }

        public int GasFlowNO { get; set; }

        public int MesinPowerOn { get; set; }

        public int MesinSelfCollibration { get; set; }

        public int MesinKebocoran { get; set; }

        public int MesinZatvolatile { get; set; }

        public int MesinAbsorber { get; set; }

        public int NafasSungkup { get; set; }

        public int NafasOropharygeal { get; set; }

        public int NafasBatang { get; set; }

        public int NafasBilah { get; set; }

        public int NafasGagang { get; set; }

        public int NafasETT { get; set; }

        public int NafasStilet { get; set; }

        public int NafasSemprit { get; set; }

        public int NafasForceps { get; set; }

        public int PemantauanKabelEKG { get; set; }

        public int PemantauanElektrodaEKG { get; set; }

        public int PemantauanNIBP { get; set; }

        public int PemantauanSpO { get; set; }

        public int PemantauanKapnografi { get; set; }

        public int PemantauanSuhu { get; set; }

        public int LainStetoskop { get; set; }

        public int LainSuction { get; set; }

        public int LainSelang { get; set; }

        public int LainPlester { get; set; }

        public int LainLidocaine { get; set; }

        public int ObatEpinefrin { get; set; }

        public int ObatAtropin { get; set; }

        public int ObatSedatif { get; set; }

        public int ObatOpiat { get; set; }

        public int ObatPelumpuhOtot { get; set; }

        public int ObatAntiBiotika { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int KodeNipPerawatAnastesi { get; set; }
        public string NamaPerawatAnastesi { get; set; }

        public int KodeNipDokterAnastesi { get; set; }
        public string NamaDokterAnastesi { get; set; }
    }
}
