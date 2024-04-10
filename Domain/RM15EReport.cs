using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM15EReport
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPetugas { get; set; }
        public byte[] ImgSignPetugas { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM15E { get; set; }
        public virtual RM15E RM15E { get; set; }

    }
}
