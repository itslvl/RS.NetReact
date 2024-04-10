using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM13B
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required(ErrorMessage = "Isi Nama Ayah Dengan Benar ..."), StringLength(50, MinimumLength = 1)]
        public string NamaAyah { get; set; }        

        [DefaultValue(0)]
        public int UmurAyah { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string NamaIbu { get; set; }


        [DefaultValue(0)]
        public int UmurIbu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [DefaultValue(0)]
        public int AlergiTidakAda { get; set; }

        [DefaultValue(0)]
        public int AlergiObat { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiObatKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiObatReaksi { get; set; }

        [DefaultValue(0)]
        public int AlergiMakanan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiMakananKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiMakananReaksi { get; set; }

        [DefaultValue(0)]
        public int AlergiLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiLainKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlergiLainReaksi { get; set; }

        [DefaultValue(0)]
        public int GelangAlergi { get; set; }

        [DefaultValue(0)]
        public int AlergiTidakDiketahui { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string KeluhanUtama { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaSekarang { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string RiwayatPenyakitSekarang { get; set; }

        [DefaultValue(0)]
        public int MasukRSSebelumnyaTidak { get; set; }

        [DefaultValue(0)]
        public int MasukRSSebelumnyaYa { get; set; }

        [DefaultValue(0)]
        public int LamaMasukRSSebelumnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlasanMasukRSSebelumnya { get; set; }

        [DefaultValue(0)]
        public int RiwayatOperasiTidak { get; set; }

        [DefaultValue(0)]
        public int RiwayatOperasiYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RiwayatOperasiKeterangan { get; set; }

        [DefaultValue(0)]
        public int RiwayatJantung { get; set; }

        [DefaultValue(0)]
        public int RiwayatNefrotik { get; set; }

        [DefaultValue(0)]
        public int RiwayatDM { get; set; }

        [DefaultValue(0)]
        public int RiwayatAsma { get; set; }

        [DefaultValue(0)]
        public int RiwayatEpilepsi { get; set; }

        [DefaultValue(0)]
        public int RiwayatLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RiwayatLainnyaKeterangan { get; set; }

        [DefaultValue(0)]
        public int LamaKehamilan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KomplikasiKehamilan { get; set; }

        [DefaultValue(0)]
        public int LahirSpontan { get; set; }

        [DefaultValue(0)]
        public int LahirForcep { get; set; }

        [DefaultValue(0)]
        public int LahirVacum { get; set; }

        [DefaultValue(0)]
        public int LahirSectio { get; set; }

        [DefaultValue(0)]
        public int LahirTindakanLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LahirTindakanLainKeterangan { get; set; }

        [DefaultValue(0)]
        public decimal LahirBB { get; set; }

        [DefaultValue(0)]
        public decimal LahirPanjang { get; set; }

        [DefaultValue(0)]
        public int LahirDukun { get; set; }

        [DefaultValue(0)]
        public int LahirBidan { get; set; }

        [DefaultValue(0)]
        public int LahirDokter { get; set; }

        [DefaultValue(0)]
        public int LahirLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LahirLainnyaKeterangan { get; set; }

        [DefaultValue(0)]
        public int AsiBulan { get; set; }

        [DefaultValue(0)]
        public int MakanTambahan { get; set; }

        [DefaultValue(0)]
        public int ImunisasiLengkap { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ImunisasiLengkapKeterangan { get; set; }

        [DefaultValue(0)]
        public int ImunisasiTidakLengkap { get; set; }

        [DefaultValue(0)]
        public int ImunisasiLainnya { get; set; }

        [DefaultValue(0)]
        public int SadarCompos { get; set; }

        [DefaultValue(0)]
        public int SadarSomnolen { get; set; }

        [DefaultValue(0)]
        public int SadarSopor { get; set; }

        [DefaultValue(0)]
        public int SadarKoma { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SpO2 { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Pernafasan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Nadi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TekananDarah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Suhu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DasarBB { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DasarTinggi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DasarKepala { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Hidung { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Mulut { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Telinga { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Sensori { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Motorik { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string Ketidaknyamanan { get; set; }

        [DefaultValue(0)]
        public int DietAsi { get; set; }

        [DefaultValue(0)]
        public int DietSusuFormula { get; set; }

        [DefaultValue(0)]
        public int DietBuburSusu { get; set; }

        [DefaultValue(0)]
        public int DietBuburNasi { get; set; }

        [DefaultValue(0)]
        public int TurunBBTidak { get; set; }

        [DefaultValue(0)]
        public int TurunBBYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TurunBBKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TurunBBSejak { get; set; }

        [DefaultValue(0)]
        public int InfusIntravena { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string InfusIntravenaLokasi { get; set; }

        public DateTime? InfusIntravenaTanggal { get; set; }

        [DefaultValue(0)]
        public int Cvp { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string CvpLokasi { get; set; }

        public DateTime? CvpTanggal { get; set; }

        [DefaultValue(0)]
        public int Dower { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DowerLokasi { get; set; }

        public DateTime? DowerTanggal { get; set; }

        [DefaultValue(0)]
        public int Ngt { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NgtLokasi { get; set; }

        public DateTime? NgtTanggal { get; set; }

        [DefaultValue(0)]
        public int Cystotomy { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string CystotomyLokasi { get; set; }

        public DateTime? CystotomyTanggal { get; set; }

        [DefaultValue(0)]
        public int Tracheostomy { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string TracheostomyLokasi { get; set; }

        public DateTime? TracheostomyTanggal { get; set; }

        [DefaultValue(0)]
        public int InfeksiTidakDiketahui { get; set; }

        [DefaultValue(0)]
        public int InfeksiSuspect { get; set; }

        [DefaultValue(0)]
        public int InfeksiDiketahui { get; set; }

        [DefaultValue(0)]
        public int InfeksiMrsa { get; set; }

        [DefaultValue(0)]
        public int InfeksiTB { get; set; }

        [DefaultValue(0)]
        public int InfeksiOpportunistic { get; set; }

        [DefaultValue(0)]
        public int InfeksiLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string InfeksiLainnyaKeterangan { get; set; }

        [DefaultValue(0)]
        public int BicaraNormalYa { get; set; }

        [DefaultValue(0)]
        public int BicaraNormalTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BicaraNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int BahasaIndonesia { get; set; }

        [DefaultValue(0)]
        public int BahasaDaerah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BahasaDaerahKeterangan { get; set; }

        [DefaultValue(0)]
        public int BahasaInggris { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BahasaInggrisKeterangan { get; set; }

        [DefaultValue(0)]
        public int BahasaLainnya { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BahasaLainnyaKeterangan { get; set; }

        [DefaultValue(0)]
        public int PenerjemahTidak { get; set; }

        [DefaultValue(0)]
        public int PenerjemahYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PenerjemahKeterangan { get; set; }

        [DefaultValue(0)]
        public int BahasaIsyaratTidak { get; set; }

        [DefaultValue(0)]
        public int BahasaIsyaratYa { get; set; }

        [DefaultValue(0)]
        public int HambatanBahasa { get; set; }

        [DefaultValue(0)]
        public int HambatanPendengaran { get; set; }

        [DefaultValue(0)]
        public int HambatanMemori { get; set; }

        [DefaultValue(0)]
        public int HambatanMotivasi { get; set; }

        [DefaultValue(0)]
        public int HambatanPenglihatan { get; set; }

        [DefaultValue(0)]
        public int HambatanTidakDitemukan { get; set; }

        [DefaultValue(0)]
        public int HambatanCemas { get; set; }

        [DefaultValue(0)]
        public int HambatanEmosi { get; set; }

        [DefaultValue(0)]
        public int HambatanBicara { get; set; }

        [DefaultValue(0)]
        public int HambatanKognitif { get; set; }

        [DefaultValue(0)]
        public int HambatanFisiologis { get; set; }

        [DefaultValue(0)]
        public int SukaMenulis { get; set; }

        [DefaultValue(0)]
        public int SukaAudio { get; set; }

        [DefaultValue(0)]
        public int SukaDiskusi { get; set; }

        [DefaultValue(0)]
        public int SukaMembaca { get; set; }

        [DefaultValue(0)]
        public int SukaMendengar { get; set; }

        [DefaultValue(0)]
        public int SukaDemostrasi { get; set; }

        [DefaultValue(0)]
        public int BelajarPenyakit { get; set; }

        [DefaultValue(0)]
        public int BelajarPengobatan { get; set; }

        [DefaultValue(0)]
        public int BelajarTerapi { get; set; }

        [DefaultValue(0)]
        public int NyeriTidak { get; set; }

        [DefaultValue(0)]
        public int NyeriYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriLokasi { get; set; }

        [DefaultValue(0)]
        public int NyeriAkut { get; set; }

        [DefaultValue(0)]
        public int NyeriKronis { get; set; }

        [DefaultValue(0)]
        public int NyeriSkala { get; set; }

        [DefaultValue(0)]
        public int NafasSulitTidak { get; set; }

        [DefaultValue(0)]
        public int NafasSulitYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NafasSulitO2 { get; set; }

        [DefaultValue(0)]
        public int NafasSulitNasal { get; set; }

        [DefaultValue(0)]
        public int NafasSulitSungkup { get; set; }

        [DefaultValue(0)]
        public int DekubitusTidak { get; set; }

        [DefaultValue(0)]
        public int DekubitusPernah { get; set; }

        [DefaultValue(0)]
        public int DekubitusPernahBelum { get; set; }

        [DefaultValue(0)]
        public int DekubitusPernahTelah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DekubitusDi { get; set; }

        [DefaultValue(0)]
        public int LukaTidakAda { get; set; }

        [DefaultValue(0)]
        public int LukaAda { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LukaLokasi { get; set; }

        [DefaultValue(0)]
        public int ResikoDekubitusBelum { get; set; }

        [DefaultValue(0)]
        public int ResikoDekubitusTelah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string ResikoDekubitusTelahDi { get; set; }

        [DefaultValue(0)]
        public int MakanTidakAda { get; set; }

        [DefaultValue(0)]
        public int MakanMenelan { get; set; }

        [DefaultValue(0)]
        public int MakanKhusus { get; set; }

        [DefaultValue(0)]
        public int MakanCairan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MakanKeterangan { get; set; }

        [DefaultValue(0)]
        public int KemihTidakAda { get; set; }

        [DefaultValue(0)]
        public int KemihAda { get; set; }

        [DefaultValue(0)]
        public int KemihStoma { get; set; }

        [DefaultValue(0)]
        public int KemihStricture { get; set; }

        [DefaultValue(0)]
        public int KemihRetensi { get; set; }

        [DefaultValue(0)]
        public int KemihInkontinensia { get; set; }

        [DefaultValue(0)]
        public int KemihDialysis { get; set; }

        [DefaultValue(0)]
        public int DefekasiTidakAda { get; set; }

        [DefaultValue(0)]
        public int DefekasiAda { get; set; }

        [DefaultValue(0)]
        public int DefekasiStoma { get; set; }

        [DefaultValue(0)]
        public int DefekasiAthresia { get; set; }

        [DefaultValue(0)]
        public int DefekasiKonstipasi { get; set; }

        [DefaultValue(0)]
        public int DefekasiInkontinensia { get; set; }

        [DefaultValue(0)]
        public int DefekasiDiare { get; set; }

        public DateTime? DischargePlanning { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string PulangKe { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string EdukasiPulang { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSkalaNyeri { get; set; }
        public string NamaImgSignPerawat1 { get; set; }
        public string NamaImgSignPerawat2 { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodePekerjaanAyah { get; set; }
        public virtual RPekerjaan RPekerjaanAyah { get; set; }

        public int KodePendidikanAyah { get; set; }
        public virtual RPendidikan RPendidikanAyah { get; set; }

        public int KodePekerjaanIbu { get; set; }
        public virtual RPekerjaan RPekerjaanIbu { get; set; }

        public int KodePendidikanIbu { get; set; }
        public virtual RPendidikan RPendidikanIbu { get; set; }

        public int KodeNipPerawat1 { get; set; }
        public virtual TPegawai TPegawaiPerawat1 { get; set; }

        public int KodeNipPerawat2 { get; set; }
        public virtual TPegawai TPegawaiPerawat2 { get; set; }


        //PK
        //public ICollection<RM13BReport> LstRM13BReport { get; set; }

    }
}
