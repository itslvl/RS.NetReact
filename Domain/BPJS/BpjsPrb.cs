using System.ComponentModel.DataAnnotations;
using System;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsPrb
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoSrb { get; set; } = "";
        [Required] public string TglSrb { get; set; } = "";
        [Required] public string NoSep { get; set; } = "";
        [Required] public string Alamat { get; set; } = "";
        [Required] public string Email { get; set; } = "";
        [Required] public string KodeProgramPRB { get; set; } = "";
        [Required] public string NamaProgramPRB { get; set; } = "";
        [Required] public string KodeFaskes { get; set; } = "";
        [Required] public string NamaFaskes { get; set; } = "";
        [Required] public string KodeDPJP { get; set; } = "";
        [Required] public string NamaDPJP { get; set; } = "";
        [Required] public string Keterangan { get; set; } = "";
        [Required] public string Saran { get; set; } = "";
        [Required] public string User { get; set; } = "";

        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
        [Required] public string Kelamin { get; set; } = "";
        [Required] public string TglLahir { get; set; } = "";

        [Required] public string KdObat { get; set; } = "";
        [Required] public string NamaObat { get; set; } = "";
        [Required] public string Signa1 { get; set; } = "";
        [Required] public string Signa2 { get; set; } = "";
        [Required] public string JmlObat { get; set; } = "";

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
