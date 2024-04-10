using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodySuratKontrolSpri
    {
        public BodySpriInsert BodySpriInsert { get; set; }
        public BodySpriUpdate BodySpriUpdate { get; set; }
        public BodySuratKontrolInsert BodySuratKontrolInsert { get; set; }
        public BodySuratKontrolUpdate BodySuratKontrolUpdate { get; set; }
    }


    public class BodySpriInsert
    {
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string PoliKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodySpriUpdate
    {
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string NoSPRI { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string PoliKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodySuratKontrolInsert
    {
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string NoSEP { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string PoliKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodySuratKontrolUpdate
    {
        //[Required] public string NoKartu { get; set; } = "";
        [Required] public string NoSuratKontrol { get; set; } = "";
        [Required] public string NoSEP { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string PoliKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodySuratKontrolDelete
    {
        [Required] public string NoSuratKontrol { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodySuratKontrolSpriList
    {
        [Required] public string NoSuratKontrol { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string JnsKontrol { get; set; } = "";
        [Required] public string NamaJnsKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string TglTerbitKontrol { get; set; } = "";
        [Required] public string NoSepAsalKontrol { get; set; } = "";
        [Required] public string PoliAsal { get; set; } = "";
        [Required] public string NamaPoliAsal { get; set; } = "";
        [Required] public string PoliTujuan { get; set; } = "";
        [Required] public string NamaPoliTujuan { get; set; } = "";
        [Required] public string TglSEP { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string NamaDokter { get; set; } = "";
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
    }


}
