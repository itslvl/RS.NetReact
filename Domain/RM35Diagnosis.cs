using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM35Diagnosis
    {
        [Key]
        public int Kode { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeIcd10 { get; set; }
        public virtual RICD RICD { get; set; }

        public int KodeRM35 { get; set; }
        public virtual RM35 RM35 { get; set; }

    }
}
