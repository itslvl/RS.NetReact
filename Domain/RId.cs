using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RId
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
        public ICollection<TPasien> LstTPasien { get; set; }
        public ICollection<RM62> LstRM62 { get; set; }
        public ICollection<RM65> LstRM65 { get; set; }
    }
}
