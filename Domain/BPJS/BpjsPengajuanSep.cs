using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsPengajuanSep
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoKartu { get; set; } = "";
        
        [Required] public string TglSep { get; set; } = "";
        
        [Required] public string JnsPelayanan { get; set; } = "";
        
        [Required] public string JnsPengajuan { get; set; } = "";
        
        [Required] public string Keterangan { get; set; } = "";

        [Required] public string User { get; set; } = "";
        [Required] public string NoPengajuan { get; set; } = "";
        [Required] public string JSon { get; set; } = "";

        public int UserSimrsCreate { get; set; } = 0;
        public int UserSimrsUpdate { get; set; } = 0;
        public int UserSimrsDelete { get; set; } = 0;
        public int Deleted { get; set; } = 0;

    }
}
