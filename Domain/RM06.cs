using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM06
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int CaraDatangSendiri { get; set; }

        [DefaultValue(0)]
        public int CaraDatangAmbulans { get; set; }

        [DefaultValue(0)]
        public int CaraDatangPolisi { get; set; }

        [DefaultValue(0)]
        public int CaraDatangLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string CaraDatangLainnyaKeterangan { get; set; }

        public DateTime JamDatang { get; set; }
        
        public DateTime? JamDilayani { get; set; }
        
        public DateTime? JamDirujuk { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string KeluhanUtamaPerawat { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TelaahPerawat { get; set; }

        [DefaultValue(0)]
        public int DatangTrauma { get; set; }

        [DefaultValue(0)]
        public int DatangNonTrauma { get; set; }

        [DefaultValue(0)]
        public int DatangPediatri { get; set; }

        [DefaultValue(0)]
        public int DatangObstetri { get; set; }

        [DefaultValue(0)]
        public int DatangInfeksius { get; set; }

        [DefaultValue(0)]
        public int DatangNeonatus { get; set; }

        [DefaultValue(0)]
        public int DatangDoa { get; set; }

        [DefaultValue(0)]
        public int DatangTidakAdaKehidupan { get; set; }

        [DefaultValue(0)]
        public int DatangTidakAdaNadi { get; set; }

        [DefaultValue(0)]
        public int DatangRc { get; set; }

        [DefaultValue(0)]
        public int DatangEkgFlat { get; set; }

        [DefaultValue(0)]
        public int DatangJamDoa { get; set; }

        public DateTime? JamDoa { get; set; }

        [DefaultValue(0)]
        public int KesadaranBiruGSC { get; set; }

        [DefaultValue(0)]
        public int KesadaranBiruKejang { get; set; }

        [DefaultValue(0)]
        public int KesadaranBiruRespon { get; set; }

        [DefaultValue(0)]
        public int KesadaranMerahGsc { get; set; }

        [DefaultValue(0)]
        public int KesadaranMerahGelisah { get; set; }

        [DefaultValue(0)]
        public int KesadaranMerahHemiparese { get; set; }

        [DefaultValue(0)]
        public int KesadaranMerahNyeriDada { get; set; }

        [DefaultValue(0)]
        public int KesadaranKuningGsc { get; set; }

        [DefaultValue(0)]
        public int KesadaranKuningApatis { get; set; }

        [DefaultValue(0)]
        public int KesadaranKuningSomnolen { get; set; }

        [DefaultValue(0)]
        public int KesadaranHijauGsc { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KesadaranKeterangan { get; set; }

        [DefaultValue(0)]
        public int JalanNafasBiruSumbatan { get; set; }

        [DefaultValue(0)]
        public int JalanNafasMerahBebas { get; set; }

        [DefaultValue(0)]
        public int JalanNafasMerahAncaman { get; set; }

        [DefaultValue(0)]
        public int JalanNafasKuningBebas { get; set; }

        [DefaultValue(0)]
        public int JalanNafasHijauBebas { get; set; }

        [DefaultValue(0)]
        public int PernafasanBiruHenti { get; set; }

        [DefaultValue(0)]
        public int PernafasanBiruBradiphone { get; set; }

        [DefaultValue(0)]
        public int PernafasanBiruSianosis { get; set; }

        [DefaultValue(0)]
        public int PernafasanMerahTakiphone { get; set; }

        [DefaultValue(0)]
        public int PernafasanMerahMengi { get; set; }

        [DefaultValue(0)]
        public int PernafasanMerahNeonatus { get; set; }

        [DefaultValue(0)]
        public int PernafasanMerahSuhu { get; set; }

        [DefaultValue(0)]
        public int PernafasanMerahDehidrasi { get; set; }

        [DefaultValue(0)]
        public int PernafasanKuningNormal { get; set; }

        [DefaultValue(0)]
        public int PernafasanKuningMengi { get; set; }

        [DefaultValue(0)]
        public int PernafasanKuningRonchi { get; set; }

        [DefaultValue(0)]
        public int PernafasanHijauNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PernafasanFrekuensi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PernafasanSaO2 { get; set; }

        [DefaultValue(0)]
        public int SirkulasiBiruJantung { get; set; }

        [DefaultValue(0)]
        public int SirkulasiBiruNadi { get; set; }

        [DefaultValue(0)]
        public int SirkulasiBiruAkral { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahNadi { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahBradikardia { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahTakikardia { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahPucat { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahAkral { get; set; }

        [DefaultValue(0)]
        public int SirkulasiMerahCRT { get; set; }

        [DefaultValue(0)]
        public int SirkulasiKuningNadi { get; set; }

        [DefaultValue(0)]
        public int SirkulasiKuningTakikardia { get; set; }

        [DefaultValue(0)]
        public int SirkulasiKuningTDS160 { get; set; }

        [DefaultValue(0)]
        public int SirkulasiKuningTDS100 { get; set; }

        [DefaultValue(0)]
        public int SirkulasiHijauNadi { get; set; }

        [DefaultValue(0)]
        public int SirkulasiHijauTakikardia { get; set; }

        [DefaultValue(0)]
        public int SirkulasiHijauTDS120 { get; set; }

        [DefaultValue(0)]
        public int SirkulasiHijauTDS80 { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SirkulasiTD { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SirkulasiNadi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SirkulasiSuhu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SirkulasiAlergi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SirkulasiImunisasi { get; set; }

        [DefaultValue(0)]
        public int Nps0 { get; set; }

        [DefaultValue(0)]
        public int Nps12 { get; set; }

        [DefaultValue(0)]
        public int Nps34 { get; set; }

        [DefaultValue(0)]
        public int Nps5 { get; set; }

        [DefaultValue(0)]
        public int Flacc0 { get; set; }

        [DefaultValue(0)]
        public int Flacc12 { get; set; }

        [DefaultValue(0)]
        public int Flacc34 { get; set; }

        [DefaultValue(0)]
        public int Flacc5 { get; set; }

        [DefaultValue(0)]
        public int WorgBaker0 { get; set; }

        [DefaultValue(0)]
        public int WorgBaker13 { get; set; }

        [DefaultValue(0)]
        public int WorgBaker46 { get; set; }

        [DefaultValue(0)]
        public int WorgBaker710 { get; set; }

        [DefaultValue(0)]
        public int PsikologiMasalah { get; set; }

        [DefaultValue(0)]
        public int PsikologiMarah { get; set; }

        [DefaultValue(0)]
        public int PsikologiTakut { get; set; }

        [DefaultValue(0)]
        public int PsikologiCemas { get; set; }

        [DefaultValue(0)]
        public int PsikologiDepresi { get; set; }

        [DefaultValue(0)]
        public int PsikologiLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PsikologiLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhYa { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhTidak { get; set; }

        [DefaultValue(0)]
        public int NyeriYa { get; set; }

        [DefaultValue(0)]
        public int NyeriTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Nyeri { get; set; }

        [DefaultValue(0)]
        public int SkalaNyeri { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KualitasNyeri { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LokasiNyeri { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DurasiNyeri { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string FrekuensiNyeri { get; set; }

        [DefaultValue(0)]
        public int Jatuh3BulanYa { get; set; }

        [DefaultValue(0)]
        public int Jatuh3BulanTidak { get; set; }

        [DefaultValue(0)]
        public int JatuhAlatBantuYa { get; set; }

        [DefaultValue(0)]
        public int JatuhAlatBantuTidak { get; set; }

        [DefaultValue(0)]
        public int JatuhJalanYa { get; set; }

        [DefaultValue(0)]
        public int JatuhJalanTidak { get; set; }

        [DefaultValue(0)]
        public int JatuhPagar { get; set; }

        [DefaultValue(0)]
        public int JatuhEdukasi { get; set; }

        [DefaultValue(0)]
        public int JatuhGelang { get; set; }

        [DefaultValue(0)]
        public int GiziTurunBbYa { get; set; }

        [DefaultValue(0)]
        public int GiziTurunBbTidak { get; set; }

        [DefaultValue(0)]
        public int GiziNafsuMakanYa { get; set; }

        [DefaultValue(0)]
        public int GiziNafsuMakanTidak { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string KeluhanUtamaDokter { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string TelaahDokter { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaKepala { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaMata { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaTelinga { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaHidung { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaGigi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaTenggorokan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaLeher { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaDada { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaJantung { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaParu { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaAbdomen { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaLiver { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaUsus { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaLain { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaPenunjang { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string PeriksaLaboratorium { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Genetalia { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Ekstremitas { get; set; }        

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Terapi { get; set; }

        public string NamaImgWorgBakers { get; set; }
        public string NamaImgPria { get; set; }
        public string NamaImgWanita { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public string NamaImgSignDokter { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }



        //PK
        public ICollection<RM06Obat> LstRM06Obat { get; set; }
        
    }
}
