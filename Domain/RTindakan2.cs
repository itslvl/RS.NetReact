using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RTindakan2
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeTindakan1 { get; set; }
        public virtual RTindakan1 RTindakan1 { get; set; }

        //PK
        public ICollection<RTindakan3> LstTindakan3 { get; set; }
    }
}
