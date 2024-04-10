using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RCustomer
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Direktur { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NoHP { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NoTelp { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Deskripsi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }
    }
}
