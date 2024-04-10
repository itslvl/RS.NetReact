using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TRegistrasi
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime TglMasuk { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? TglKeluar { get; set; }

        [DefaultValue(0)]
        public int Urut { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NamaPasien { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan Tindakan dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal Tindakan { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan Obat KEsehatan dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal ObatAlkes { get; set; }

        public decimal Total
        {
            get
            {
                return Tindakan + ObatAlkes;
            }
            set { }
        }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal Deposit { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal Piutang { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal Diskon { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal DiskonPaket { get; set; }

        public decimal BayarSelisih { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal BayarPasien { get; set; }

        public decimal? SisaBayar
        {
            get
            {
                return (Tindakan + ObatAlkes) -
                       (Diskon + DiskonPaket + Deposit + Piutang) - (Bayar);
            }
            set { }
        }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal Bayar { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Penjamin { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NmPenjamin { get; set; }

        [DefaultValue(0)]
        public int UmurPenjamin { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string AlamatPenjamin { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string HubKeluarga { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NoTelpPenjamin { get; set; }

        [DefaultValue(0)]
        public int IsRujukAwal { get; set; }

        [DefaultValue(0)]
        public int IsSuratRujukan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NoSep { get; set; }

        [DefaultValue(0)]
        public int IsTenggangBPJS { get; set; }

        [DefaultValue(0.00)]
        public decimal NilaiCoding { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string LevelCoding { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal SelisihCoding { get; set; }

        //[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Gunakan 2 dibelakang koma")]
        [DefaultValue(0.00)]
        public decimal LimitBudget { get; set; }

        [DefaultValue(0)]
        public int NamaBudget { get; set; }

        [DefaultValue(0)]
        public int NamaAdmit { get; set; }

        [DefaultValue(0)]
        public int NamaBayar { get; set; }

        [DefaultValue(0)]
        public int NamaBayarUlang { get; set; }


        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignPetugas { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }


        //FK
        public int KodePasien { get; set; }
        public virtual TPasien TPasien { get; set; }
        public int KodeRawat { get; set; }
        public virtual RRawat RRawat { get; set; }
        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }
        public int KodeBed { get; set; }
        public virtual RRuang5 RRuang5Bed { get; set; }
        public int KodeBedAwal { get; set; }
        public virtual RRuang5 RRuang5BedAwal { get; set; }
        public int KodeCaraBayar3 { get; set; }
        public virtual RCaraBayar3 RCaraBayar3 { get; set; }
        public int KodePenjamin { get; set; }
        public virtual RPenjamin RPenjamin { get; set; }
        public int PekerjaanPenjamin { get; set; }
        public virtual RPekerjaan RPekerjaanPenjamin { get; set; }
        public int KodeDokterIGD { get; set; }
        public TPegawai TPegawaiDokterIGD { get; set; }
        public int DPJP { get; set; }
        public TPegawai TPegawaiDPJP { get; set; }
        public int KodePengirim { get; set; }
        public virtual RPengirim RPengirim { get; set; }        
        public int KodeRujukan { get; set; }
        public virtual RRujukan RRujukan { get; set; }
        public int KodeRujukKeluar { get; set; }
        public virtual RRujukKeluar RRujukKeluar { get; set; }
        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        //PK
        public ICollection<TResep> LstTResep { get; set; }
        public ICollection<TRegistrasiBed> LstTRegistrasiBed { get; set; }
        public ICollection<TTindakan1> LstTTindakan1 { get; set; }
        public ICollection<TReturResep> LstTReturResep { get; set; }
        public ICollection<TRL> LstTRL { get; set; }
        public ICollection<TRL39> LstTRL39 { get; set; }
        public ICollection<TRL310> LstTRL310 { get; set; }
        public ICollection<TBayarSelisih> LstTBayarSelisih { get; set; }
        public ICollection<TDeposit> LstTDeposit { get; set; }


        public ICollection<RM01Report> LstRM01Report { get; set; }
        public ICollection<RM01A> LstRM01A { get; set; }

        public ICollection<RM02> LstRM02 { get; set; }
        public ICollection<RM02Report> LstRM02Report { get; set; }
        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM03Report> LstRM03Report { get; set; }
        public ICollection<RM04> LstRM04 { get; set; }
        public ICollection<RM04Report> LstRM04Report { get; set; }
        public ICollection<RM05> LstRM05 { get; set; }
        public ICollection<RM05Report> LstRM05Report { get; set; }
        public ICollection<RM06> LstRM06 { get; set; }
        public ICollection<RM06Report> LstRM06Report { get; set; }
        public ICollection<RM07> LstRM07 { get; set; }
        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }
        public ICollection<RM10> LstRM10 { get; set; }


        public ICollection<RM11> LstRM11 { get; set; }
        public ICollection<RM11Report> LstRM11Report { get; set; }
        public ICollection<RM12A> LstRM12A { get; set; }
        public ICollection<RM12AReport> LstRM12AReport { get; set; }
        public ICollection<RM13B> LstRM13B { get; set; }
        public ICollection<RM13BReport> LstRM13BReport { get; set; }
        public ICollection<RM15A> LstRM15A { get; set; }
        public ICollection<RM15D> LstRM15D { get; set; }
        public ICollection<RM15DReport> LstRM15DReport { get; set; }
        public ICollection<RM15E> LstRM15E { get; set; }
        public ICollection<RM16> LstRM16 { get; set; }
        public ICollection<RM17> LstRM17 { get; set; }
        public ICollection<RM19> LstRM19 { get; set; }
        public ICollection<RM22> LstRM22 { get; set; }
        public ICollection<RM22Report> LstRM22Report { get; set; }
        public ICollection<RM23> LstRM23 { get; set; }
        public ICollection<RM23Report> LstRM23Report { get; set; }


        public ICollection<RM24> LstRM24 { get; set; }
        public ICollection<RM25> LstRM25 { get; set; }
        public ICollection<RM26> LstRM26 { get; set; }
        public ICollection<RM27> LstRM27 { get; set; }
        public ICollection<RM28> LstRM28 { get; set; }
        public ICollection<RM29> LstRM29 { get; set; }
        public ICollection<RM30> LstRM30 { get; set; }
        public ICollection<RM31> LstRM31 { get; set; }
        public ICollection<RM32> LstRM32 { get; set; }
        public ICollection<RM34> LstRM34 { get; set; }
        public ICollection<RM35> LstRM35 { get; set; }
        public ICollection<RM36> LstRM36 { get; set; }
        public ICollection<RM37> LstRM37 { get; set; }
        public ICollection<RM39> LstRM39 { get; set; }
        public ICollection<RM40> LstRM40 { get; set; }
        public ICollection<RM41> LstRM41 { get; set; }
        public ICollection<RM42> LstRM42 { get; set; }
        
        public ICollection<RM45> LstRM45 { get; set; }
        public ICollection<RM45Report> LstRM45Report { get; set; }
        public ICollection<RM46> LstRM46 { get; set; }
        public ICollection<RM46Report> LstRM46Report { get; set; }
        public ICollection<RM49> LstRM49 { get; set; }
        public ICollection<RM49Report> LstRM49Report { get; set; }
        public ICollection<RM50> LstRM50 { get; set; }
        public ICollection<RM50Report> LstRM50Report { get; set; }
        public ICollection<RM53> LstRM53 { get; set; }
        public ICollection<RM56> LstRM56 { get; set; }
        public ICollection<RM58> LstRM58 { get; set; }
        public ICollection<RM58Report> LstRM58Report { get; set; }
        public ICollection<RM61> LstRM61 { get; set; }
        public ICollection<RM62> LstRM62 { get; set; }
        public ICollection<RM65> LstRM65 { get; set; }
        public ICollection<RM65Report> LstRM65Report { get; set; }


        public ICollection<TRequestResep> LstTRequestResep { get; set; }
        public ICollection<TRequestLab> LstTRequestLab { get; set; }
        public ICollection<TRequestRadiologi> LstTRequestRadiologi { get; set; }



        public ICollection<SSResume> LstSSResume { get; set; }

        public ICollection<THonor> LstTHonor { get; set; }
    }
}
