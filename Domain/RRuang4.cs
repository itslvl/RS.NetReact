using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RRuang4
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0)]
        public int IsUmum { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        //FK
        public int KodeKelasRuang { get; set; }
        public virtual RKelasRuang RKelasRuang { get; set; }
        public int KodeRL13 { get; set; }
        public virtual RRL13 RRL13 { get; set; }
        public int KodeAplicares { get; set; }
        public virtual RAplicaresKelas RAplicaresKelas { get; set; }
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
       
        //PK
        public ICollection<RRuang5> LstRuang5 { get; set; }
    }
}
