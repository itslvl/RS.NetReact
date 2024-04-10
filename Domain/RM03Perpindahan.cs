using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM03Perpindahan
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime TglPindah { get; set; }
        
        public DateTime? TglKeluar { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }
        


        //FK
        public int KodeRuang5 { get; set; }
        public virtual RRuang5 RRuang5 { get; set; }

        public int KodeRL31 { get; set; }
        public virtual RRL31 RRL31 { get; set; }

        public int KodeRM03 { get; set; }
        public virtual RM03 RM03 { get; set; }

    }
}
