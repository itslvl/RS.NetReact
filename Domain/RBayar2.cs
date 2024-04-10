using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain{
    public class RBayar2
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int IsMinus { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }
        
        //FK
        public int KodeBayar1 { get; set; }
        public virtual RBayar1 RBayar1 { get; set; }

        //PK
        [InverseProperty("RBayar2AkunJalan")]
        public ICollection<RTindakan1> LstTindakan1Jalan { get; set; }

        [InverseProperty("RBayar2AkunInap")]
        public ICollection<RTindakan1> LstTindakan1Inap { get; set; }
    }
}
