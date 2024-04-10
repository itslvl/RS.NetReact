using System.ComponentModel.DataAnnotations;
using System;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsRujukanKeluar
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoRujukan { get; set; } = "";
        [Required] public string NoSep { get; set; } = "";
        [Required] public string TglRujukan { get; set; } = "";
        [Required] public string TglRencanaKunjungan { get; set; } = "";
        [Required] public string PpkDirujuk { get; set; } = "";
        [Required] public string NamaPpkDirujuk { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string Catatan { get; set; } = "";
        [Required] public string DiagRujukan { get; set; } = "";
        [Required] public string NamaDiagRujukan { get; set; } = "";
        [Required] public string TipeRujukan { get; set; } = "";
        [Required] public string PoliRujukan { get; set; } = "";
        [Required] public string NamaPoliRujukan { get; set; } = "";
        [Required] public string User { get; set; } = "";
        [Required] public string TglBerlakuRujukan { get; set; } = "";

        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
        [Required] public string Kelamin { get; set; } = "";
        [Required] public string TglLahir { get; set; } = "";

        [Required] public string JsonInsert { get; set; } = "";
        [Required] public string JsonUpdate { get; set; } = "";
        [Required] public string JsonDelete { get; set; } = "";
        [Required] public string JsonInsertResponse { get; set; } = "";
        [Required] public string JsonUpdateResponse { get; set; } = "";
        [Required] public string JsonDeleteResponse { get; set; } = "";

        public int UserSimrsCreate { get; set; } = 0;
        public int UserSimrsUpdate { get; set; } = 0;
        public int UserSimrsDelete { get; set; } = 0;
        public int Deleted { get; set; } = 0;
    }
}
