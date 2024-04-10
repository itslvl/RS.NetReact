using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RCaraBayar3
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
        public int KodeCaraBayar2 { get; set; }
        public virtual RCaraBayar2 RCaraBayar2 { get; set; }
        public int KodeGrupCaraBayar { get; set; }
        public virtual RGrupCaraBayar RGrupCaraBayar { get; set; }

        //PK
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }
        public ICollection<RM02> LstRM02 { get; set; }

    }
}
