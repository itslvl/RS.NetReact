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
    public class RM12A
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string AlasanMasuk { get; set; }

        [DefaultValue(0)]
        public int PernahDirawatYa { get; set; }

        [DefaultValue(0)]
        public int PernahDirawatTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KapanDirawat { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DimanaDirawat { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string DiagnosaDirawat { get; set; }

        [DefaultValue(0)]
        public int ImplanTerpasang { get; set; }

        [DefaultValue(0)]
        public string ImplanTerpasangKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        public string Obat { get; set; }

        [DefaultValue(0)]
        public int AlergiTidak { get; set; }

        [DefaultValue(0)]
        public int AlergiObat { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiObatKeterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiObatReaksi { get; set; }

        [DefaultValue(0)]
        public int AlergiMakanan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiMakananKeterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiMakananReaksi { get; set; }

        [DefaultValue(0)]
        public int AlergiLainnya { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiLainnyaKeterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlergiLainnyaReaksi { get; set; }

        [DefaultValue(0)]
        public int GelangAlergi { get; set; }

        [DefaultValue(0)]
        public int AlergiTidakDiketahui { get; set; }

        [DefaultValue(0)]
        public int PsikologisCemas { get; set; }

        [DefaultValue(0)]
        public int PsikologisTakut { get; set; }

        [DefaultValue(0)]
        public int PsikologisMarah { get; set; }

        [DefaultValue(0)]
        public int PsikologisSedih { get; set; }

        [DefaultValue(0)]
        public int PsikologisBunuhDiri { get; set; }

        [DefaultValue(0)]
        public int PsikologisLain { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string PsikologisLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int MentalSadar { get; set; }

        [DefaultValue(0)]
        public int MentalPerilaku { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string MentalPerilakuKeterangan { get; set; }

        [DefaultValue(0)]
        public int MentalKekerasan { get; set; }

        [DefaultValue(0)]
        public int SosialHubunganBaik { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string SosialTinggal { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string SosialNama { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SosialNoTelp { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SpiritualBiasa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SpiritualPerawatan { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string TD { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Nadi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Pernafasan { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string Suhu { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string BB { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        public string TB { get; set; }

        [DefaultValue(0)]
        public int MuntahYa { get; set; }

        [DefaultValue(0)]
        public int MuntahTidak { get; set; }

        [DefaultValue(0)]
        public int PendengaranNormal { get; set; }

        [DefaultValue(0)]
        public int PendengaranTidakNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PendengaranTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int PenglihatanNormal { get; set; }

        [DefaultValue(0)]
        public int PenglihatanTidakNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PenglihatanTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int DefekasiNormal { get; set; }

        [DefaultValue(0)]
        public int DefekasiTidakNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DefekasiTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int MiksiNormal { get; set; }

        [DefaultValue(0)]
        public int MiksiTidakNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string MiksiTidakNormalKeterangan { get; set; }

        [DefaultValue(0)]
        public int HamilYa { get; set; }

        [DefaultValue(0)]
        public int HamilTidak { get; set; }
        public DateTime? HPHT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KeluhanMenstruasi { get; set; }

        [DefaultValue(0)]
        public int KulitNormal { get; set; }

        [DefaultValue(0)]
        public int KulitTidakNormal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string KulitTidakNormalKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SkorBraden { get; set; }

        [DefaultValue(0)]
        public int DekubitusYa { get; set; }

        [DefaultValue(0)]
        public int DekubitusTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PemeriksaanFisik { get; set; }

        [DefaultValue(0)]
        public int PemeriksaanKhususYa { get; set; }

        [DefaultValue(0)]
        public int PemeriksaanKhususTidak { get; set; }

        [DefaultValue(0)]
        public int BBTurunTidak { get; set; }

        [DefaultValue(0)]
        public int BBTurunTidakTahu { get; set; }

        [DefaultValue(0)]
        public int BBTurun1SetengahKg { get; set; }

        [DefaultValue(0)]
        public int BBTurun610Kg { get; set; }

        [DefaultValue(0)]
        public int BBTurun1115Kg { get; set; }

        [DefaultValue(0)]
        public int BBTurunLebih15Kg { get; set; }

        [DefaultValue(0)]
        public int BBTurunTidakYakin { get; set; }

        [DefaultValue(0)]
        public int NafsuMakanTidak { get; set; }

        [DefaultValue(0)]
        public int NafsuMakanYa { get; set; }

        [DefaultValue(0)]
        public int TotalSkor { get; set; }

        [DefaultValue(0)]
        public int DiagnosaKhususYa { get; set; }

        [DefaultValue(0)]
        public int DiagnosaKhususTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string DiagnosaKhususKeterangan { get; set; }

        [DefaultValue(0)]
        public int NutrisionisYa { get; set; }

        [DefaultValue(0)]
        public int NutrisionisTidak { get; set; }
        public DateTime? DiketahuiNutrisionis { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhTidak { get; set; }

        [DefaultValue(0)]
        public int ResikoJatuhYa { get; set; }

        [DefaultValue(0)]
        public int GelangKuning { get; set; }

        [DefaultValue(0)]
        public int AktifitasMandiri { get; set; }

        [DefaultValue(0)]
        public int AktifitasBantuan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AktifitasBantuanKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string AlatBantuKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string SkalaNyeri { get; set; }

        [DefaultValue(0)]
        public int NyeriKronis { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriKronisLokasi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriKronisIntensitas { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriKronisAktivitas { get; set; }

        [DefaultValue(0)]
        public int NyeriAkut { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriAkutLokasi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriAkutIntensitas { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NyeriAkutAktivitas { get; set; }

        [DefaultValue(0)]
        public int NyeriTidakAda { get; set; }

        [DefaultValue(0)]
        public int NyeriHilangObat { get; set; }

        [DefaultValue(0)]
        public int NyeriHilangIstirahat { get; set; }

        [DefaultValue(0)]
        public int NyeriHilangMusik { get; set; }

        [DefaultValue(0)]
        public int NyeriHilangPosisi { get; set; }

        [DefaultValue(0)]
        public int HambatanTidak { get; set; }

        [DefaultValue(0)]
        public int HambatanYa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string HambatanKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiDiagnosis { get; set; }

        [DefaultValue(0)]
        public int EdukasiObat { get; set; }

        [DefaultValue(0)]
        public int EdukasiDiet { get; set; }

        [DefaultValue(0)]
        public int EdukasiKeperawatan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiKeperawatanKeterangan { get; set; }

        [DefaultValue(0)]
        public int EdukasiRehabilitasi { get; set; }

        [DefaultValue(0)]
        public int EdukasiNyeri { get; set; }

        [DefaultValue(0)]
        public int EdukasiLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string EdukasiLainKeterangan { get; set; }

        [DefaultValue(0)]
        public int HomeCareYa { get; set; }

        [DefaultValue(0)]
        public int HomeCareTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string HomeCareKeterangan { get; set; }

        [DefaultValue(0)]
        public int PemasanganImplanYa { get; set; }

        [DefaultValue(0)]
        public int PemasanganImplanTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PemasanganImplanKeterangan { get; set; }

        [DefaultValue(0)]
        public int PemesananAlatBantuYa { get; set; }

        [DefaultValue(0)]
        public int PemesananAlatBantuTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string PemesananAlatBantuKeterangan { get; set; }

        [DefaultValue(0)]
        public int RujukKomunitasYa { get; set; }

        [DefaultValue(0)]
        public int RujukKomunitasTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RujukKomunitasKeterangan { get; set; }

        [DefaultValue(0)]
        public int RujukTerapisYa { get; set; }

        [DefaultValue(0)]
        public int RujukTerapisTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RujukTerapisKeterangan { get; set; }

        [DefaultValue(0)]
        public int RujukGiziYa { get; set; }

        [DefaultValue(0)]
        public int RujukGiziTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string RujukGiziKeterangan { get; set; }

        [DefaultValue(0)]
        public int LainYa { get; set; }

        [DefaultValue(0)]
        public int LainTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string LainKeterangan { get; set; }
        
        public DateTime TglPembuatanKajian { get; set; }
        
        public DateTime? TglPelengkapKajian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgLokasiLuka { get; set; }
        public string NamaImgSkalaNyeri { get; set; }
        public string NamaImgSignPerawatPembuat { get; set; }
        public string NamaImgSignPerawatPelengkap { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeHubunganKeluargaSosial { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeNipPerawatPembuatKajian { get; set; }
        public virtual TPegawai TPegawaiPembuatKajian { get; set; }

        public int KodeNipPerawatPelengkapKajian { get; set; }
        public virtual TPegawai TPegawaiPelengkapKajian { get; set; }



        //PK
        public ICollection<RM12AMasalahKeperawatan> LstRM12AMasalahKeperawatan { get; set; }
        //public ICollection<RM12AReport> LstRM12AReport { get; set; }
    }
}
