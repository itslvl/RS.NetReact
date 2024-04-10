using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RAgama
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
        public ICollection<TPegawai> LstTPegawai { get; set; }
        public ICollection<TPasien> LstTPasien { get; set; }

        public ICollection<RM50> LstRM50 { get; set; }
    }
}
