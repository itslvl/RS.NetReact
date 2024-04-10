using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RRuang2
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        //FK
        public int KodeRuang1 { get; set; }
        public virtual RRuang1 RRuang1 { get; set; }

        //PK
        public ICollection<RRuang3> LstRuang3 { get; set; }
    }
}
