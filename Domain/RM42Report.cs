using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM42Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPerawatICU { get; set; }
        public byte[] ImgSignPerawatICU { get; set; }
        public string NamaImgSignPerawatRR { get; set; }
        public byte[] ImgSignPerawatRR { get; set; }
        

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM42 { get; set; }
        public virtual RM42 RM42 { get; set; }

    }
}
