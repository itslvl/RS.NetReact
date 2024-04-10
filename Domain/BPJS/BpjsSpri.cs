using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsSpri
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoSPRI { get; set; } = "";
        [Required] public string TglRencanaKontrol { get; set; } = "";
        [Required] public string NamaDokter { get; set; } = "";
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
        [Required] public string Kelamin { get; set; } = "";
        [Required] public string TglLahir { get; set; } = "";
        [Required] public string NamaDiagnosa { get; set; } = "";

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
