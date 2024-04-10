using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM35
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int GigiY { get; set; }

        [DefaultValue(0)]
        public int GigiT { get; set; }

        [DefaultValue(0)]
        public int MobilisasiLeherY { get; set; }

        [DefaultValue(0)]
        public int MobilisasiLeherT { get; set; }

        [DefaultValue(0)]
        public int LeherPendekY { get; set; }

        [DefaultValue(0)]
        public int LeherPendekT { get; set; }

        [DefaultValue(0)]
        public int BatukY { get; set; }

        [DefaultValue(0)]
        public int BatukT { get; set; }

        [DefaultValue(0)]
        public int SesakNafasY { get; set; }

        [DefaultValue(0)]
        public int SesakNafasT { get; set; }

        [DefaultValue(0)]
        public int InfeksiY { get; set; }

        [DefaultValue(0)]
        public int InfeksiT { get; set; }

        [DefaultValue(0)]
        public int SaluranNafasAtasY { get; set; }

        [DefaultValue(0)]
        public int SaluranNafasAtasT { get; set; }

        [DefaultValue(0)]
        public int SakitDadaY { get; set; }

        [DefaultValue(0)]
        public int SakitDadaT { get; set; }

        [DefaultValue(0)]
        public int DenyutJantungY { get; set; }

        [DefaultValue(0)]
        public int DenyutJantungT { get; set; }

        [DefaultValue(0)]
        public int MuntahY { get; set; }

        [DefaultValue(0)]
        public int MuntahT { get; set; }

        [DefaultValue(0)]
        public int PingsanY { get; set; }

        [DefaultValue(0)]
        public int PingsanT { get; set; }

        [DefaultValue(0)]
        public int StrokeY { get; set; }

        [DefaultValue(0)]
        public int StrokeT { get; set; }

        [DefaultValue(0)]
        public int KejangY { get; set; }

        [DefaultValue(0)]
        public int KejangT { get; set; }

        [DefaultValue(0)]
        public int HamilY { get; set; }

        [DefaultValue(0)]
        public int HamilT { get; set; }

        [DefaultValue(0)]
        public int TulangBelakangY { get; set; }

        [DefaultValue(0)]
        public int TulangBelakangT { get; set; }

        [DefaultValue(0)]
        public int ObesitasY { get; set; }

        [DefaultValue(0)]
        public int ObesitasT { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Keterangan { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Tinggi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Berat { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string TekananDarah { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Nadi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Suhu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuSkorMallampati { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuGigiPalsu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuJantung { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuParuParu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuAbdomen { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuTulangBelakang { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuEkstremitas { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuNeurologi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KuKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabHbHt { get; set; }

        [DefaultValue(0)]
        public int LabHbHtY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabPt { get; set; }

        [DefaultValue(0)]
        public int LabPtY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabGlukosa { get; set; }

        [DefaultValue(0)]
        public int LabGlukosaY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabTesKehamilan { get; set; }

        [DefaultValue(0)]
        public int LabTesKehamilanY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabKalium { get; set; }

        [DefaultValue(0)]
        public int LabKaliumY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabUreum { get; set; }

        [DefaultValue(0)]
        public int LabUreumY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabLeukosit { get; set; }

        [DefaultValue(0)]
        public int LabLeukositY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabTrombosit { get; set; }

        [DefaultValue(0)]
        public int LabTrombositY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabRontgenDada { get; set; }

        [DefaultValue(0)]
        public int LabRontgenDadaY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabEkg { get; set; }

        [DefaultValue(0)]
        public int LabEkgY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabNaCl { get; set; }

        [DefaultValue(0)]
        public int LabNaClY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LabKreatinin { get; set; }

        [DefaultValue(0)]
        public int LabKreatininY { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string LabKeterangan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string CatatanTindakLanjut { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AnastesiSedasi { get; set; }

        [DefaultValue(0)]
        public int AnastesiSedasiY { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AnastesiGa { get; set; }

        [DefaultValue(0)]
        public int AnastesiGaY { get; set; }

        [DefaultValue(0)]
        public int AnastesiRegionalY { get; set; }

        [DefaultValue(0)]
        public int AnastesiSpinalY { get; set; }

        [DefaultValue(0)]
        public int AnastesiEpiduralY { get; set; }

        [DefaultValue(0)]
        public int AnastesiKaudalY { get; set; }

        [DefaultValue(0)]
        public int AnastesiBlokPeriferY { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AnastesiLain { get; set; }

        [DefaultValue(0)]
        public int AnastesiLainY { get; set; }

        [DefaultValue(0)]
        public int TeknikHipotensiY { get; set; }

        [DefaultValue(0)]
        public int TeknikVentilasiY { get; set; }

        [DefaultValue(0)]
        public int TeknikTciY { get; set; }

        [DefaultValue(0)]
        public int TeknikLainY { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string TeknikLain { get; set; }

        [DefaultValue(0)]
        public int MonitoringEkgY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MonitoringEkg { get; set; }

        [DefaultValue(0)]
        public int MonitoringSpO2Y { get; set; }

        [DefaultValue(0)]
        public int MonitoringNibpY { get; set; }

        [DefaultValue(0)]
        public int MonitoringTempY { get; set; }

        [DefaultValue(0)]
        public int MonitoringLainY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MonitoringLain { get; set; }

        [DefaultValue(0)]
        public int MonitoringCvpY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MonitoringCvp { get; set; }

        [DefaultValue(0)]
        public int MonitoringArteriY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MonitoringArteri { get; set; }

        [DefaultValue(0)]
        public int MonitoringEtCo2Y { get; set; }

        [DefaultValue(0)]
        public int MonitoringBisY { get; set; }

        [DefaultValue(0)]
        public int AlatBronchoscopyY { get; set; }

        [DefaultValue(0)]
        public int AlatGlidescopeY { get; set; }

        [DefaultValue(0)]
        public int AlatUsgY { get; set; }

        [DefaultValue(0)]
        public int AlatLainY { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string AlatLain { get; set; }

        [DefaultValue(0)]
        public int PascaRawatInapY { get; set; }

        [DefaultValue(0)]
        public int PascaRawatJalanY { get; set; }

        [DefaultValue(0)]
        public int PascaRawatKhususY { get; set; }

        [DefaultValue(0)]
        public int PascaIcuY { get; set; }

        [DefaultValue(0)]
        public int PascaHduY { get; set; }

        [DefaultValue(0)]
        public int PascaLainY { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PascaLain { get; set; }
        public DateTime PersiapanPuasa { get; set; }
        public DateTime PersiapanPreMedikasi { get; set; }
        public DateTime PersiapanTransportasi { get; set; }
        public DateTime PersiapanRencanaOperasi { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string KolomTindakLanjut { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string CatatanPersiapan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }



        //PK
        public ICollection<RM35Penyulit> LstRM35Penyulit { get; set; }
        public ICollection<RM35Diagnosis> LstRM35Diagnosis { get; set; }
        public ICollection<RM35Report> LstRM35Report { get; set; }


    }
}
