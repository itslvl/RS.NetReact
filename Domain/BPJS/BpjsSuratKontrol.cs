using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsSuratKontrol
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoSuratKontrol { get; set; } = "";
        [Required] public string NoSEP { get; set; } = "";
        [Required] public string KodeDokter { get; set; } = "";
        [Required] public string NamaDokter { get; set; } = "";
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
        [Required] public string Kelamin { get; set; } = "";
        [Required] public string TglLahir { get; set; } = "";
        [Required] public string PoliKontrol { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string Diagnosa { get; set; } = "";
        [Required] public string SubSpesialis { get; set; } = "";
        [Required] public string User { get; set; } = "";
        public int Deleted { get; set; } = 0;

        [Required] public string JsonInsert { get; set; } = "";
        [Required] public string JsonUpdate { get; set; } = "";
        [Required] public string JsonDelete { get; set; } = "";
        [Required] public string JsonInsertResponse { get; set; } = "";
        [Required] public string JsonUpdateResponse { get; set; } = "";
        [Required] public string JsonDeleteResponse { get; set; } = "";

        [Required] public int UserSimrsCreate { get; set; } = 0;
        [Required] public int UserSimrsUpdate { get; set; } = 0;
        [Required] public int UserSimrsDelete { get; set; } = 0;

        

    }


    
}
