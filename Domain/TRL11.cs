using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class TRL11
    {
        public Guid id { get; set; } = new Guid();

        [DefaultValue(0)]
        public int Tahun { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue("")]
        [MaxLength(10)]
        public string KodeRs { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglRegistrasi { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NamaRsKapital { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string JenisRs { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string KelasRs { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NamaDirektur { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string NamaPenyelenggara { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string LokasiRs { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string KabKota { get; set; }

        [DefaultValue("")]
        [MaxLength(10)]
        public string KodePos { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Telepon { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Fax { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string Email { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string NoTeleponHumas { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string Website { get; set; }

        [DefaultValue(0)]
        public decimal LuasTanah { get; set; }

        [DefaultValue(0)]
        public decimal LuasBangunan { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string IzinNomor { get; set; }

        [DataType(DataType.Date)]
        public DateTime? IzinTanggal { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string IzinOleh { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        public string IzinSifat { get; set; }

        [DataType(DataType.Date)]
        public DateTime? IzinMasaBerlaku { get; set; }

        [DefaultValue("")]
        [MaxLength(100)]
        public string StatusPenyelenggara { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string AkreditasiRs { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string AkreditasiPentahapan { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string AkreditasiStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime? AkreditasiTanggal { get; set; }

        [DefaultValue(0)]
        public int BedPerinatologi { get; set; }

        [DefaultValue(0)]
        public int BedVvip { get; set; }

        [DefaultValue(0)]
        public int BedVip { get; set; }

        [DefaultValue(0)]
        public int BedKelas1 { get; set; }

        [DefaultValue(0)]
        public int BedKelas2 { get; set; }

        [DefaultValue(0)]
        public int BedKelas3 { get; set; }

        [DefaultValue(0)]
        public int BedIcu { get; set; }

        [DefaultValue(0)]
        public int BedPicu { get; set; }

        [DefaultValue(0)]
        public int BedNicu { get; set; }

        [DefaultValue(0)]
        public int BedHcu { get; set; }

        [DefaultValue(0)]
        public int BedIccu { get; set; }

        [DefaultValue(0)]
        public int BedIsolasi { get; set; }

        [DefaultValue(0)]
        public int BedUgd { get; set; }

        [DefaultValue(0)]
        public int BedBersalin { get; set; }

        [DefaultValue(0)]
        public int BedOperasi { get; set; }

        [DefaultValue(0)]
        public int DokterSpA { get; set; }

        [DefaultValue(0)]
        public int DokterSpOg { get; set; }

        [DefaultValue(0)]
        public int DokterSpPd { get; set; }

        [DefaultValue(0)]
        public int DokterSpB { get; set; }

        [DefaultValue(0)]
        public int DokterSpRad { get; set; }

        [DefaultValue(0)]
        public int DokterSpRm { get; set; }

        [DefaultValue(0)]
        public int DokterSpAn { get; set; }

        [DefaultValue(0)]
        public int DokterSpJp { get; set; }

        [DefaultValue(0)]
        public int DokterSpM { get; set; }

        [DefaultValue(0)]
        public int DokterSpTht { get; set; }

        [DefaultValue(0)]
        public int DokterSpKj { get; set; }

        [DefaultValue(0)]
        public int DokterSpP { get; set; }

        [DefaultValue(0)]
        public int DokterSpPk { get; set; }

        [DefaultValue(0)]
        public int DokterSpPd2 { get; set; }

        [DefaultValue(0)]
        public int DokterSpS { get; set; }

        [DefaultValue(0)]
        public int DokterSubSpesialis { get; set; }

        [DefaultValue(0)]
        public int DokterSpesialisLain { get; set; }

        [DefaultValue(0)]
        public int DokterUmum { get; set; }

        [DefaultValue(0)]
        public int DokterGigi { get; set; }

        [DefaultValue(0)]
        public int DokterGigiSpesialis { get; set; }

        [DefaultValue(0)]
        public int Perawat { get; set; }

        [DefaultValue(0)]
        public int Bidan { get; set; }

        [DefaultValue(0)]
        public int Farmasi { get; set; }

        [DefaultValue(0)]
        public int NakesLain { get; set; }

        [DefaultValue(0)]
        public int NonNakes { get; set; }

        public int CpKodeNip { get; set; }
        public int CpKodeJabatan { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string CpEmail { get; set; }

        [DefaultValue("")]
        [MaxLength(50)]
        public string CpNoTelp { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CpTanggal { get; set; }

    }
}
