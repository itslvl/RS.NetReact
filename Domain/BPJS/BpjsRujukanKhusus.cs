using System.ComponentModel.DataAnnotations;
using System;

namespace DotNet.RS.Models.BPJS
{
    public class BpjsRujukanKhusus
    {
        public Guid Id { get; set; } = new Guid();
        [Required] public string NoRujukan { get; set; } = "";
        [Required] public string DxPrimer { get; set; } = "";
        [Required] public string DxSekunder { get; set; } = "";
        [Required] public string Procedure { get; set; } = "";
        [Required] public string User { get; set; } = "";
        [Required] public string JSon { get; set; } = "";
        public int UserSimrsCreate { get; set; } = 0;
        public int UserSimrsUpdate { get; set; } = 0;
        public int UserSimrsDelete { get; set; } = 0;
        public int Deleted { get; set; } = 0;
    }
}
