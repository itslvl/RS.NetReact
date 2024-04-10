using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RJenisKelamin
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
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }

        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }

        public ICollection<RM24> LstRM24 { get; set; }
        public ICollection<RM29> LstRM29 { get; set; }
        public ICollection<RM31> LstRM31 { get; set; }

        public ICollection<RM50> LstRM50 { get; set; }
        public ICollection<RM56> LstRM56 { get; set; }
        public ICollection<RM58> LstRM58 { get; set; }
        public ICollection<RM62> LstRM62 { get; set; }

    }
}
