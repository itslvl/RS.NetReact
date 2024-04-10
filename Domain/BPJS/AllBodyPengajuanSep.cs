using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodyPengajuanSep
    {
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string TglSep { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string JnsPengajuan { get; set; } = "";
        [Required] public string Keterangan { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    
}
