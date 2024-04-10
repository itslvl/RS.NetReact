using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RICD9
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string KodeIcd9 { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string KodeIcd9Titik { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //PK
        public ICollection<RM01A> LstRM01A { get; set; }
        public ICollection<RM01ATindakan> LstRM01ATindakan { get; set; }
        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM03ICD9> LstRM03ICD9 { get; set; }
        public ICollection<RM23> LstRM23 { get; set; }
        public ICollection<RM23Tindakan> LstRM23Tindakan { get; set; }
        public ICollection<TRL> LstTRL { get; set; }
    }
}
