using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class BPJSSep
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoSep { get; set; } = "";
        [Required] public string TglSep { get; set; } = "";
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string NoMR { get; set; } = "";        
        [Required] public string Nama { get; set; } = "";
        [Required] public string TglLahir { get; set; } = "";
        [Required] public string Kelamin { get; set; } = "";
        [Required] public string NoTelp { get; set; } = "";
        [Required] public string Tujuan { get; set; } = "";
        [Required] public string UraianTujuan { get; set; } = "";
        [Required] public string KodeDPJP { get; set; } = "";
        [Required] public string NamaDpjp { get; set; } = "";
        [Required] public string AsalRujukan { get; set; } = "";
        [Required] public string PpkRujukan { get; set; } = "";
        [Required] public string NamaPpkRujukan { get; set; } = "";        
        [Required] public string DiagAwal { get; set; } = "";
        [Required] public string UraianDiagAwal { get; set; } = "";
        [Required] public string Catatan { get; set; } = "";
        [Required] public string JnsPeserta { get; set; } = "";
        [Required] public string Cob { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string TujuanKunj { get; set; } = "";
        [Required] public string KlsRawatHak { get; set; } = "";
        [Required] public string KlsRawat { get; set; } = "";
        [Required] public string Penjamin { get; set; } = "";
        [Required] public string Dinsos { get; set; } = "";
        [Required] public string ESEP { get; set; } = "";
        [Required] public string NoSKTM { get; set; } = "";
        [Required] public string ProlanisPRB { get; set; } = "";
        [Required] public int IsSepInternal { get; set; } = 0;

        [Required] public string JsonInsert { get; set; } = "";
        [Required] public string JsonUpdate { get; set; } = "";
        [Required] public string JsonDelete { get; set; } = "";
        [Required] public string JsonPulang { get; set; } = "";
        [Required] public string JsonInsertResponse { get; set; } = "";
        [Required] public string JsonUpdateResponse { get; set; } = "";
        [Required] public string JsonDeleteResponse { get; set; } = "";
        [Required] public string JsonPulangResponse { get; set; } = "";

        [Required] public int UserSimrsCreate { get; set; } = 0;
        [Required] public int UserSimrsUpdate { get; set; } = 0;
        [Required] public int UserSimrsDelete { get; set; } = 0;
        [Required] public int UserSimrsPulang { get; set; } = 0;

        public int Deleted { get; set; } = 0;
    }
}
