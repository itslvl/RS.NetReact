using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodyICare
    {
        [Required] public string Param { get; set; } = "";
        [Required] public int Kodedokter { get; set; } = 0;
    }
}
