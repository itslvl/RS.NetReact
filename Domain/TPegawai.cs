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
    public class TPegawai
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NIP { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Nama { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string TempatLahir { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TglLahir { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Alamat { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TglMasuk { get; set; }

        [DefaultValue("")]
        public string PictFile { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string NoTelp { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Password { get; set; }

        [DefaultValue(0)]
        public int? AtasanLangsungKode { get; set; }

        [DefaultValue(0)]
        public int IsFakasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue("")]
        public string ImageUrl { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Email { get; set; }

        public string IdNIK { get; set; } = "";
        public string IdBPJS { get; set; } = "";


        //FK
        public int KodePendidikan3 { get; set; }
        public virtual RPendidikan3 RPendidikan3 { get; set; }
        public int KodeAgama { get; set; }
        public virtual RAgama RAgama { get; set; }
        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }
        public int KodeGolongan { get; set; }
        public virtual RGolongan RGolongan { get; set; }
        public int KodePerkawinan { get; set; }
        public virtual RPerkawinan RPerkawinan { get; set; }
        public int KodeJabatan { get; set; }
        public virtual RJabatan RJabatan { get; set; }
        //public int JabatanMedisKode { get; set; }
        public int KodeNegara { get; set; }
        public virtual RNegara RNegara { get; set; }
        public int KodeSuku { get; set; }
        public virtual RSuku RSuku { get; set; }
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
        public int KodePendidikan { get; set; }
        public virtual RPendidikan RPendidikan { get; set; }


        [Display(Name = "Image")]
        [NotMapped]
        public IFormFile FileImage { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //PK
        //public ICollection<RRuang3> LstRRuang3 { get; set; }
        public ICollection<TMutasiDt> LstTMutasiDt { get; set; }
        public ICollection<TPembelian> LstTPembelian { get; set; }
        public ICollection<TResepDt> LstTResepDt { get; set; }
        public ICollection<TReturResepDt> LstTReturResepDt { get; set; }

        [InverseProperty("TPegawaiNIPTerima")]
        public ICollection<TMutasi> LstTMutasiNIPTerima { get; set; }

        [InverseProperty("TPegawaiNIPRequest")]
        public ICollection<TMutasi> LstTMutasiNIPRequest { get; set; }

        [InverseProperty("TPegawaiKodeDokter")]
        public ICollection<TResep> LstTResepKodeDokter { get; set; }
        [InverseProperty("TPegawaiKodeApoteker")]
        public ICollection<TResep> LstTResepKodeApoteker { get; set; }

        [InverseProperty("TPegawaiDokterIGD")]
        public ICollection<TRegistrasi> LstTRegistrasiDokterIGD { get; set; }

        [InverseProperty("TPegawaiDPJP")]
        public ICollection<TRegistrasi> LstTRegistrasiDPJP { get; set; }
        public ICollection<TReturPembelian> LstTReturPembelian { get; set; }
        //public ICollection<TReturMutasiDt> LstTReturMutasiDt { get; set; }

        //[InverseProperty("TPegawaiNIPTerima")]
        //public ICollection<TReturMutasi> LstTReturMutasiNIPTerima { get; set; }

        //[InverseProperty("TPegawaiNIPRequest")]
        //public ICollection<TReturMutasi> LstTReturMutasiNIPRequest { get; set; }

        [InverseProperty("TPegawaiDokter1")]
        public ICollection<TTindakan1> LstTindakan1Dokter1 { get; set; }

        [InverseProperty("TPegawaiDokter2")]
        public ICollection<TTindakan1> LstTindakan1Dokter2 { get; set; }

        [InverseProperty("TPegawaiKodeDokter")]
        public ICollection<TReturResep> LstTReturResepKodeDokter { get; set; }
        [InverseProperty("TPegawaiKodeApoteker")]
        public ICollection<TReturResep> LstTReturResepKodeApoteker { get; set; }
        public ICollection<TTutupStok> LstTTutupStok { get; set; }
        public ICollection<TLogistikExpired> LstTLogistikExpired { get; set; }
        public ICollection<TLogistikOperasional> LstTLogistikOperasional { get; set; }

        [InverseProperty("TPegawaiKonsinyasiTerima")]
        public ICollection<TKonsinyasi> LstTKonsinyasiTerima { get; set; }
        [InverseProperty("TPegawaiKonsinyasiRequest")]
        public ICollection<TKonsinyasi> LstTKonsinyasiRequest { get; set; }

        public ICollection<TBayarSelisih> LstTBayarSelisih { get; set; }

        [InverseProperty("TPegawaiKasir")]
        public ICollection<TDeposit> LstTDepositKasir { get; set; }
        [InverseProperty("TPegawaiEdit")]
        public ICollection<TDeposit> LstTDepositKasirEdit { get; set; }
        [InverseProperty("TPegawaiHapus")]
        public ICollection<TDeposit> LstTDepositKasirHapus { get; set; }

        public ICollection<RM01A> LstRM01A { get; set; }

        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM04> LstRM04 { get; set; }
        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM05> LstRM05Dpjp { get; set; }
        [InverseProperty("TPegawaiPetugas")]
        public ICollection<RM05> LstRM05Petugas { get; set; }
        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM06> LstRM06Perawat { get; set; }
        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM06> LstRM06Dokter { get; set; }
        public ICollection<RM07Edukasi> LstRM07Edukasi { get; set; }
        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }
        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM10> LstRM10Dpjp { get; set; }
        [InverseProperty("TPegawaiKonsulen1")]
        public ICollection<RM10> LstRM10Konsulen1 { get; set; }
        [InverseProperty("TPegawaiKonsulen2")]
        public ICollection<RM10> LstRM10Konsulen2 { get; set; }
        [InverseProperty("TPegawaiMenyerahkan")]
        public ICollection<RM10> LstRM10PegawaiMenyerahkan { get; set; }
        [InverseProperty("TPegawaiMenerima")]
        public ICollection<RM10> LstRM10PegawaiMenerima { get; set; }




        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM11> LstRM11Dokter { get; set; }

        [InverseProperty("TPegawaiPembuatKajian")]
        public ICollection<RM12A> LstRM12APegawaiPembuatKajian { get; set; }
        [InverseProperty("TPegawaiPelengkapKajian")]
        public ICollection<RM12A> LstRM12APegawaiPelengkapKajian { get; set; }

        [InverseProperty("TPegawaiPerawat1")]
        public ICollection<RM13B> LstRM13BPegawaiPerawat1 { get; set; }
        [InverseProperty("TPegawaiPerawat2")]
        public ICollection<RM13B> LstRM13BPegawaiPerawat2 { get; set; }

        [InverseProperty("TPegawaiPetugas")]
        public ICollection<RM15B> LstRM15BPegawai { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM15D> LstRM15DPegawaiDokter { get; set; }
        [InverseProperty("TPegawaiPenilai")]
        public ICollection<RM15D> LstRM15DPegawaiPenilai { get; set; }

        [InverseProperty("TPegawai")]
        public ICollection<RM15E> LstRM15EPegawai { get; set; }

        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM16> LstRM16Perawat { get; set; }

        [InverseProperty("TPegawai")]
        public ICollection<RM17> LstRM17Pegawai { get; set; }

        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM19> LstRM19PegawaiPerawat { get; set; }
        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM19> LstRM19PegawaiDokter { get; set; }
        [InverseProperty("TPegawaiPetugas")]
        public ICollection<RM19> LstRM19PegawaiPetugas { get; set; }

        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM22> LstRM22PegawaiDpjp { get; set; }
        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM22> LstRM22PegawaiPerawat { get; set; }

        [InverseProperty("TPegawaiDPJP")]
        public ICollection<RM23> LstRM23PegawaiDPJP { get; set; }



        [InverseProperty("TPegawaiOperator")]
        public ICollection<RM24> LstRM24Operator { get; set; }
        [InverseProperty("TPegawaiPemberiInformasi")]
        public ICollection<RM24> LstRM24PemberiInformasi { get; set; }

        [InverseProperty("TPegawaiDokterOperator")]
        public ICollection<RM25> LstRM25DokterOperator { get; set; }
        [InverseProperty("TPegawaiSaksiRS")]
        public ICollection<RM25> LstRM25PegawaiSaksiRS { get; set; }

        [InverseProperty("TPegawaiRuangan")]
        public ICollection<RM26> LstRM26PegawaiRuangan { get; set; }
        [InverseProperty("TPegawaiOK")]
        public ICollection<RM26> LstRM26PegawaiOK { get; set; }
        [InverseProperty("TPegawaiOK2")]
        public ICollection<RM26> LstRM26PegawaiOK2 { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM27> LstRM27TPegawaiDokter { get; set; }
        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM27> LstRM27TPegawaiPerawat { get; set; }

        [InverseProperty("TPegawaiDokterOperator")]
        public ICollection<RM28> LstRM28PegawaiDokterOperator { get; set; }
        [InverseProperty("TPegawaiInformasi")]
        public ICollection<RM28> LstRM28PegawaiInformasi { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM29> LstRM29PegawaiDokter { get; set; }
        [InverseProperty("TPegawaiSaksi")]
        public ICollection<RM29> LstRM29PegawaiSaksi { get; set; }

        [InverseProperty("TPegawaiPerawatAnastesi")]
        public ICollection<RM30> LstRM30PegawaiPerawatAnastesi { get; set; }
        [InverseProperty("TPegawaiDokterAnastesi")]
        public ICollection<RM30> LstRM30PegawaiDokterAnastesi { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM31> LstRM31Dokter { get; set; }

        [InverseProperty("TPegawaiPemberiInformasi")]
        public ICollection<RM32> LstRM32PemberiInformasi { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM34> LstRM34Dokter { get; set; }
        
        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM35> LstRM35Dokter { get; set; }

        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM36> LstRM36PegawaiPerawat { get; set; }
        [InverseProperty("TPegawaiKepalaRuangan")]
        public ICollection<RM36> LstRM36PegawaiKepalaRuangan { get; set; }

        [InverseProperty("TPegawaiPerawatSignIn")]
        public ICollection<RM37> LstRM37PegawaiPerawatSignIn { get; set; }
        [InverseProperty("TPegawaiPerawatTimeOut")]
        public ICollection<RM37> LstRM37PegawaiPerawatTimeOut { get; set; }
        [InverseProperty("TPegawaiDokterAnastesiSignOut")]
        public ICollection<RM37> LstRM37PegawaiDokterAnastesiSignOut { get; set; }
        [InverseProperty("TPegawaiDokterBedahSignOut")]
        public ICollection<RM37> LstRM37PegawaiDokterBedahSignOut { get; set; }
        [InverseProperty("TPegawaiPerawatSignOut")]
        public ICollection<RM37> LstRM37PegawaiPerawatSignOut { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM39> LstRM39PegawaiDokter { get; set; }

        [InverseProperty("TPegawaiDokterOperator")]
        public ICollection<RM40> LstRM40PegawaiDokterOperator { get; set; }
        [InverseProperty("TPegawaiDokterAnastesi")]
        public ICollection<RM40> LstRM40PegawaiDokterAnastesi { get; set; }
        [InverseProperty("TPegawaiAsistenOperator")]
        public ICollection<RM40> LstRM40PegawaiAsistenOperator { get; set; }
        [InverseProperty("TPegawaiPerawatAnastesi")]
        public ICollection<RM40> LstRM40PegawaiPerawatAnastesi { get; set; }

        [InverseProperty("TPegawaiPetugasRuangan")]
        public ICollection<RM41> LstRM41PegawaiPetugasRuangan { get; set; }
        [InverseProperty("TPegawaiPetugasOK")]
        public ICollection<RM41> LstRM41PegawaiPetugasOK { get; set; }

        [InverseProperty("TPegawaiPerawatPenerima")]
        public ICollection<RM42> LstRM42PegawaiPerawatPenerima { get; set; }
        [InverseProperty("TPegawaiPerawatRR")]
        public ICollection<RM42> LstRM42PegawaiPerawatRR { get; set; }

        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM45> LstRM45PegawaiDpjp { get; set; }
        [InverseProperty("TPegawaiPerujuk")]
        public ICollection<RM45> LstRM45PegawaiPerujuk { get; set; }
        [InverseProperty("TPegawaiStaf1")]
        public ICollection<RM45> LstRM45PegawaiStaf1 { get; set; }
        [InverseProperty("TPegawaiStaf2")]
        public ICollection<RM45> LstRM45PegawaiStaf2 { get; set; }

        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM49> LstRM49PegawaiDpjp { get; set; }

        [InverseProperty("TPegawaiKepalaRuangan")]
        public ICollection<RM50> LstRM50PegawaiKepalaRuangan { get; set; }

        [InverseProperty("TPegawaiPemberiInformasi")]
        public ICollection<RM53> LstRM53PegawaiPemberiInformasi { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM56> LstRM56PegawaiDokter { get; set; }
        [InverseProperty("TPegawaiSaksiRS")]
        public ICollection<RM56> LstRM56PegawaiSaksiRS { get; set; }

        [InverseProperty("TPegawaiYangMenyerahkan")]
        public ICollection<RM61> LstRM61PegawaiYangMenyerahkan { get; set; }
        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM61> LstRM61PegawaiDpjp { get; set; }

        [InverseProperty("TPegawaiDokter")]
        public ICollection<RM62> LstRM62PegawaiDokter { get; set; }
        [InverseProperty("TPegawaiSaksiRS")]
        public ICollection<RM62> LstRM62PegawaiSaksiRS { get; set; }

        [InverseProperty("TPegawaiPerawat")]
        public ICollection<RM65> LstRM65PegawaiPerawat { get; set; }
        [InverseProperty("TPegawaiDpjp")]
        public ICollection<RM65> LstRM65PegawaiDpjp { get; set; }

        [InverseProperty("TPegawaiKodeDokterRequest")]
        public ICollection<TRequestResep> LstTRequestResepDokterRequest { get; set; }
        [InverseProperty("TPegawaiKodePerawatRequest")]
        public ICollection<TRequestResep> LstTRequestResepPerawatRequest { get; set; }

        [InverseProperty("TPegawaiKodeDokterRequest")]
        public ICollection<TRequestLab> LstTRequestLabDokterRequest { get; set; }
        [InverseProperty("TPegawaiKodeDokterTujuan")]
        public ICollection<TRequestLab> LstTRequestLabDokterTujuanRequest { get; set; }
        [InverseProperty("TPegawaiKodePerawatRequest")]
        public ICollection<TRequestLab> LstTRequestLabPerawatRequest { get; set; }

        [InverseProperty("TPegawaiKodeDokterRequest")]
        public ICollection<TRequestRadiologi> LstTRequestRadiologiDokterRequest { get; set; }
        [InverseProperty("TPegawaiKodeDokterTujuan")]
        public ICollection<TRequestRadiologi> LstTRequestRadiologiDokterTujuanRequest { get; set; }
        [InverseProperty("TPegawaiKodePerawatRequest")]
        public ICollection<TRequestRadiologi> LstTRequestRadiologiPerawatRequest { get; set; }


        public ICollection<THonor> LstTHonor { get; set; }

    }
}