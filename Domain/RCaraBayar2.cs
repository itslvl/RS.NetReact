using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RCaraBayar2
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeCaraBayar1 { get; set; }
        public virtual RCaraBayar1 RCaraBayar1 { get; set; }

        //PK
        public ICollection<RCaraBayar3> LstRCaraBayar3 { get; set; }
    }
}
