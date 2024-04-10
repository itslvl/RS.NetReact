using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace DotNet.RS.Models
{
    public class RCaraPulang
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //PK
        public ICollection<TRL> LstTRL { get; set; }
    }
}
