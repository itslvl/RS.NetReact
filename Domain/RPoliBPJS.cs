using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RPoliBPJS
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
        public string Uraian2 { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        public ICollection<RRuang3> LstRuang3 { get; set; }
    }
}
