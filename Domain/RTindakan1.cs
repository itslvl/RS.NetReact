using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RTindakan1
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
        public int KodeBayar2AkunInap { get; set; }
        public virtual RBayar2 RBayar2AkunInap { get; set; }
        public int KodeBayar2AkunJalan { get; set; }
        public virtual RBayar2 RBayar2AkunJalan { get; set; }

        //PK
        public ICollection<RTindakan2> LstTindakan2 { get; set; }
    }
}
