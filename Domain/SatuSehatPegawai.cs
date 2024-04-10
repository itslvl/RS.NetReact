using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class SatuSehatPegawai
    {
        public int KODE { get; set; } = 0;
        public string NIP { get; set; } = string.Empty;
        public string NAMA { get; set; } = string.Empty;
        public string IDNIK { get; set; } = string.Empty;
        public string SSCODE { get; set; } = String.Empty;
    }
}
