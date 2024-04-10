using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM34
    {
        [Key]
        public int Kode { get; set; }
        

        [DefaultValue(0)]
        public int MerokokY { get; set; }

        [DefaultValue(0)]
        public int MerokokT { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string MerokokKeterangan { get; set; }

        [DefaultValue(0)]
        public int AlkoholY { get; set; }

        [DefaultValue(0)]
        public int AlkoholT { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string AlkoholKeterangan { get; set; }

        [DefaultValue(0)]
        public int KopiY { get; set; }

        [DefaultValue(0)]
        public int KopiT { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string KopiKeterangan { get; set; }

        [DefaultValue(0)]
        public int OlahRagaY { get; set; }

        [DefaultValue(0)]
        public int OlahRagaT { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string OlahRagaKeterangan { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Obat { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string ObatHerbal { get; set; }

        [DefaultValue(0)]
        public int AspirinY { get; set; }

        [DefaultValue(0)]
        public int AspirinT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string AspirinKeterangan { get; set; }

        [DefaultValue(0)]
        public int ObatAntiSakitY { get; set; }

        [DefaultValue(0)]
        public int ObatAntiSakitT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string ObatAntiSakitKeterangan { get; set; }

        [DefaultValue(0)]
        public int SteroidY { get; set; }

        [DefaultValue(0)]
        public int SteroidT { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglSteroid { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SteroidKeterangan { get; set; }

        [DefaultValue(0)]
        public int AlergiObatY { get; set; }

        [DefaultValue(0)]
        public int AlergiObatT { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string AlergiObatKeterangan { get; set; }

        [DefaultValue(0)]
        public int AlergiLateksY { get; set; }

        [DefaultValue(0)]
        public int AlergiLateksT { get; set; }

        [DefaultValue(0)]
        public int AlergiPlasterY { get; set; }

        [DefaultValue(0)]
        public int AlergiPlasterT { get; set; }

        [DefaultValue(0)]
        public int AlergiMakananY { get; set; }

        [DefaultValue(0)]
        public int AlergiMakananT { get; set; }

        [DefaultValue(0)]
        public int KeluargaPendarahanY { get; set; }

        [DefaultValue(0)]
        public int KeluargaPendarahanT { get; set; }

        [DefaultValue(0)]
        public int KeluargaPembekuanY { get; set; }

        [DefaultValue(0)]
        public int KeluargaPembekuanT { get; set; }

        [DefaultValue(0)]
        public int KeluargaPembiusanY { get; set; }

        [DefaultValue(0)]
        public int KeluargaPembiusanT { get; set; }

        [DefaultValue(0)]
        public int KeluargaKoronerY { get; set; }

        [DefaultValue(0)]
        public int KeluargaKoronerT { get; set; }

        [DefaultValue(0)]
        public int KeluargaDiabetesY { get; set; }

        [DefaultValue(0)]
        public int KeluargaDiabetesT { get; set; }

        [DefaultValue(0)]
        public int KeluargaSeranganJantungY { get; set; }

        [DefaultValue(0)]
        public int KeluargaSeranganJantungT { get; set; }

        [DefaultValue(0)]
        public int KeluargaHipertensiY { get; set; }

        [DefaultValue(0)]
        public int KeluargaHipertensiT { get; set; }

        [DefaultValue(0)]
        public int KeluargaTuberculosisY { get; set; }

        [DefaultValue(0)]
        public int KeluargaTuberculosisT { get; set; }

        [DefaultValue(0)]
        public int KeluargaPenyakitLainY { get; set; }

        [DefaultValue(0)]
        public int KeluargaPenyakitLainT { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string KeluargaKeterangan { get; set; }

        [DefaultValue(0)]
        public int KomunikasiBahasaIndonesia { get; set; }

        [DefaultValue(0)]
        public int KomunikasiBahasaLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string KomunikasiLain { get; set; }

        [DefaultValue(0)]
        public int KomunikasiButaY { get; set; }

        [DefaultValue(0)]
        public int KomunikasiButaT { get; set; }

        [DefaultValue(0)]
        public int KomunikasiTuliY { get; set; }

        [DefaultValue(0)]
        public int KomunikasiTuliT { get; set; }

        [DefaultValue(0)]
        public int KomunikasiBicaraY { get; set; }

        [DefaultValue(0)]
        public int KomunikasiBicaraT { get; set; }

        [DefaultValue(0)]
        public int PasienPendarahanY { get; set; }

        [DefaultValue(0)]
        public int PasienPendarahanT { get; set; }

        [DefaultValue(0)]
        public int PasienPembekuanY { get; set; }

        [DefaultValue(0)]
        public int PasienPembekuanT { get; set; }

        [DefaultValue(0)]
        public int PasienMaagY { get; set; }

        [DefaultValue(0)]
        public int PasienMaagT { get; set; }

        [DefaultValue(0)]
        public int PasienAnemiaY { get; set; }

        [DefaultValue(0)]
        public int PasienAnemiaT { get; set; }

        [DefaultValue(0)]
        public int PasienSesaknafasY { get; set; }

        [DefaultValue(0)]
        public int PasienSesakNafasT { get; set; }

        [DefaultValue(0)]
        public int PasienAsmaY { get; set; }

        [DefaultValue(0)]
        public int PasienAsmaT { get; set; }

        [DefaultValue(0)]
        public int PasienDiabetesY { get; set; }

        [DefaultValue(0)]
        public int PasienDiabetesT { get; set; }

        [DefaultValue(0)]
        public int PasienPingsanY { get; set; }

        [DefaultValue(0)]
        public int PasienPingsanT { get; set; }

        [DefaultValue(0)]
        public int PasienSeranganJantungY { get; set; }

        [DefaultValue(0)]
        public int PasienSeranganJantungT { get; set; }

        [DefaultValue(0)]
        public int PasienHepatitisY { get; set; }

        [DefaultValue(0)]
        public int PasienHepatitisT { get; set; }

        [DefaultValue(0)]
        public int PasienHipertensiY { get; set; }

        [DefaultValue(0)]
        public int PasienHipertensiT { get; set; }

        [DefaultValue(0)]
        public int PasienMengorokY { get; set; }

        [DefaultValue(0)]
        public int PasienMengorokT { get; set; }

        [DefaultValue(0)]
        public int PasienPenyakitBeratY { get; set; }

        [DefaultValue(0)]
        public int PasienPenyakitBeratT { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string PasienKeterangan { get; set; }

        [DefaultValue(0)]
        public int TransfusiDarahY { get; set; }

        [DefaultValue(0)]
        public int TransfusiDarahT { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string TahunTransfusi { get; set; }

        [DefaultValue(0)]
        public int HivY { get; set; }

        [DefaultValue(0)]
        public int HivT { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string TahunHiv { get; set; }

        [DefaultValue(0)]
        public int HivHasilPositif { get; set; }

        [DefaultValue(0)]
        public int HivHasilNegatif { get; set; }

        [DefaultValue(0)]
        public int LensaY { get; set; }

        [DefaultValue(0)]
        public int LensaT { get; set; }

        [DefaultValue(0)]
        public int KacaMataY { get; set; }

        [DefaultValue(0)]
        public int KacaMataT { get; set; }

        [DefaultValue(0)]
        public int AlatDengarY { get; set; }

        [DefaultValue(0)]
        public int AlatDengarT { get; set; }

        [DefaultValue(0)]
        public int GigiPalsuY { get; set; }

        [DefaultValue(0)]
        public int GigiPalsuT { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string RiwayatOperasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string RiwayatJenisAnastesi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string RiwayatAnastesiLokal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string RiwayatAnastesiRegional { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string RiwayatAnastesiUmum { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RiwayatTerakhirPeriksa { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RiwayatTerakhirPeriksaDimana { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RiwayatTerakhirPeriksaApa { get; set; }

        [DefaultValue(0)]
        public int JumlahAnak { get; set; }

        [DefaultValue(0)]
        public int JumlahHamil { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglMenstruasiTerakhir { get; set; }

        [DefaultValue(0)]
        public int MenyusuiY { get; set; }

        [DefaultValue(0)]
        public int MenyusuiT { get; set; }

        [DefaultValue(0)]
        public int KajianGigiY { get; set; }

        [DefaultValue(0)]
        public int KajianGigiT { get; set; }

        [DefaultValue(0)]
        public int KajianMobilisasiLeherY { get; set; }

        [DefaultValue(0)]
        public int KajianMobilisasiLeherT { get; set; }

        [DefaultValue(0)]
        public int KajianLeherPendekY { get; set; }

        [DefaultValue(0)]
        public int KajianLeherPendekT { get; set; }

        [DefaultValue(0)]
        public int KajianBatukY { get; set; }

        [DefaultValue(0)]
        public int KajianBatukT { get; set; }

        [DefaultValue(0)]
        public int KajianSesakNafasY { get; set; }

        [DefaultValue(0)]
        public int KajianSesakNafasT { get; set; }

        [DefaultValue(0)]
        public int KajianInfeksiY { get; set; }

        [DefaultValue(0)]
        public int KajianInfeksiT { get; set; }

        [DefaultValue(0)]
        public int KajianMenstruasiY { get; set; }

        [DefaultValue(0)]
        public int KajianMenstruasiT { get; set; }

        [DefaultValue(0)]
        public int KajianStrokeY { get; set; }

        [DefaultValue(0)]
        public int KajianStrokeT { get; set; }

        [DefaultValue(0)]
        public int KajianSakitDadaY { get; set; }

        [DefaultValue(0)]
        public int KajianSakitDadaT { get; set; }

        [DefaultValue(0)]
        public int KajianDenyutJantungY { get; set; }

        [DefaultValue(0)]
        public int KajianDenyutJantungT { get; set; }

        [DefaultValue(0)]
        public int KajianMuntahY { get; set; }

        [DefaultValue(0)]
        public int KajianMuntahT { get; set; }

        [DefaultValue(0)]
        public int KajianSusahBAKY { get; set; }

        [DefaultValue(0)]
        public int KajianSusahBAKT { get; set; }

        [DefaultValue(0)]
        public int KajianKejangY { get; set; }

        [DefaultValue(0)]
        public int KajianKejangT { get; set; }

        [DefaultValue(0)]
        public int KajianHamilY { get; set; }

        [DefaultValue(0)]
        public int KajianHamilT { get; set; }

        [DefaultValue(0)]
        public int KajianPingsanY { get; set; }

        [DefaultValue(0)]
        public int KajianPingsanT { get; set; }

        [DefaultValue(0)]
        public int KajianObesitasY { get; set; }

        [DefaultValue(0)]
        public int KajianObesitasT { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KajianKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string UmumKesadaran { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string UmumVisus { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string UmumFaring { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string UmumGigiPalsu { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string UmumKeterangan { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string FisikTinggi { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string FisikBerat { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string FisikTD { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string FisikNadi { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string FisikSuhu { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikParuParu { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikJantung { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikAbdomen { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikEktrimitas { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikNeurologi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string FisikKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabHb { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabPT { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabTesKehamilan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabUreum { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabKreatinin { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabLainLain { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabNaCl { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabCO2 { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string LabKeterangan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenDada { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenFoto { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenEKG { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenCtScan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenMRI { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string RontgenUSG { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [DefaultValue(0)]
        public int Asa1 { get; set; }

        [DefaultValue(0)]
        public int Asa2 { get; set; }

        [DefaultValue(0)]
        public int Asa3 { get; set; }
        
        [DefaultValue(0)]
        public int Asa4 { get; set; }

        [DefaultValue(0)]
        public int AnastesiUmum { get; set; }

        [DefaultValue(0)]
        public int AnastesiSungkup { get; set; }

        [DefaultValue(0)]
        public int AnastesiPipa { get; set; }

        [DefaultValue(0)]
        public int AnastesiRegional { get; set; }

        [DefaultValue(0)]
        public int AnastesiKombinasi { get; set; }

        [DefaultValue(0)]
        public int AnastesiUmumRegional { get; set; }

        [DefaultValue(0)]
        public int AnastesiIntravena { get; set; }

        [DefaultValue(0)]
        public int AnastesiLaringeal { get; set; }

        [DefaultValue(0)]
        public int AnastesiSpinal { get; set; }

        [DefaultValue(0)]
        public int AnastesiEpidural { get; set; }

        [DefaultValue(0)]
        public int AnastesiSperipheral { get; set; }
        
        public DateTime? MulaiPuasa { get; set; }
        
        public DateTime? RencanaTibadiOK { get; set; }
        
        public DateTime? RencanaOperasi { get; set; }
                
        public DateTime Tanggal { get; set; }
                
        [DefaultValue(0)]
        public int Deleted { get; set; }


        public string NamaImgSignDokter { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }


        //PK
        public ICollection<RM34Report> LstRM34Report { get; set; }

    }
}
