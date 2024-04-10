using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM36Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPerawatOK { get; set; }
        public byte[] ImgSignPerawatOK { get; set; }
        public string NamaImgSignKepalaRuanganOK { get; set; }
        public byte[] ImgSignKepalaRuanganOK { get; set; }
        

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM36 { get; set; }
        public virtual RM36 RM36 { get; set; }

    }
}
