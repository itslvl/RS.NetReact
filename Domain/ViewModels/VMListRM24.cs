using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM24
    {
        public int Kode { get; set; }

        public string NamaPenerimaInformasi { get; set; }

        public string Diagnosis { get; set; }

        public int DiagnosisCheck { get; set; }

        public string DasarDiagnosis { get; set; }

        public int DasarDiagnosisCheck { get; set; }

        public string TindakanKedokteran { get; set; }

        public int TindakanKedokteranCheck { get; set; }

        public string IndikasiTindakanKedokteran { get; set; }

        public string TataCara { get; set; }

        public int TataCaraCheck { get; set; }

        public string Tujuan { get; set; }

        public int TujuanCheck { get; set; }

        public string Resiko { get; set; }

        public int ResikoCheck { get; set; }

        public string Komplikasi { get; set; }

        public int KomplikasiCheck { get; set; }

        public string Prognosis { get; set; }

        public int PrognosisCheck { get; set; }

        public string Alternatif { get; set; }

        public int AlternatifCheck { get; set; }

        public string HalLain { get; set; }

        public int HalLainCheck { get; set; }

        public DateTime TglLahirPenerimaInformasi { get; set; }

        public string AlamatPenerimaInformasi { get; set; }

        public DateTime TglTindakan { get; set; }

        public DateTime Tanggal { get; set; }

        public string Saksi { get; set; }

        public int Setuju { get; set; }

        public int TidakSetuju { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public string NamaDokterOperator { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public string NamaPemberiInformasi { get; set; }

        public int KodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int KodeJenisKelaminPenerimaInformasi { get; set; }
        public string UraianJenisKelamin { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }
    }
}
