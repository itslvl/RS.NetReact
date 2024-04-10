using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM28
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string NamaPenerimaInformasi { get; set; }

        public string DiagnosisKerja { get; set; }

        public string DiagnosisBanding { get; set; }

        public int TindakanAnastesiUmum { get; set; }

        public int TindakanSedasi { get; set; }

        public int TindakanAnastesiSpinal { get; set; }

        public int TindakanAnastesiEpidural { get; set; }

        public int TindakanKombinasi { get; set; }

        public int TindakanAnastesiKaudal { get; set; }

        public int TindakanBlokSaraf { get; set; }

        public int TindakanLain { get; set; }

        public string TindakanLainKeterangan { get; set; }

        public int IndikasiKesadaran { get; set; }

        public int IndikasiNyeri { get; set; }

        public int IndikasiLain { get; set; }

        public string IndikasiLainKeterangan { get; set; }

        public int TataCaraPembuluhDarah { get; set; }

        public int TataCaraJarum { get; set; }

        public int TataCaraJaringan { get; set; }

        public int TataCaraLain { get; set; }

        public string TataCaraLainKeterangan { get; set; }

        public int ResikoNyeriTenggorokan { get; set; }

        public int ResikoSuara { get; set; }

        public int ResikoMualMuntah { get; set; }

        public int ResikoNyeriOtot { get; set; }

        public int ResikoTrauma { get; set; }

        public int ResikoAlergi { get; set; }

        public int ResikoInfeksi { get; set; }

        public int ResikoPenyempitan { get; set; }

        public int ResikoJalanNafas { get; set; }

        public int ResikoPendarahan { get; set; }

        public int ResikoBekuanDarah { get; set; }

        public int ResikoAwareness { get; set; }

        public int ResikoStroke { get; set; }

        public int ResikoKelumpuhan { get; set; }

        public int ResikoKematian { get; set; }

        public int ResikoPenurunanTD { get; set; }

        public int ResikoPeningkatanTD { get; set; }

        public int ResikoLain { get; set; }

        public string ResikoLainKeterangan { get; set; }

        public int KomplikasiLuka { get; set; }

        public int KomplikasiTrauma { get; set; }

        public int KomplikasiSakitPunggung { get; set; }

        public int KomplikasiKerusakanOtak { get; set; }

        public int KomplikasiKerusakanSaraf { get; set; }

        public int KomplikasiSeranganJantung { get; set; }

        public int KomplikasiIramaJantung { get; set; }

        public int KomplikasiHentiJantung { get; set; }

        public int KomplikasiLain { get; set; }

        public string KomplikasiLainKeterangan { get; set; }

        public string Prognosis { get; set; }

        public string Alternatif { get; set; }

        public string LainLain { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeNipOperator { get; set; }
        public string NamaOperator { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public string NamaPemberiInformasi { get; set; }

        public int KodeJabatanPemberiInformasi { get; set; }
        public string UraianJabatan { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public string UraianHubunganKeluarga { get; set; }

    }
}
