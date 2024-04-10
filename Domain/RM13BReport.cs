using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM13BReport
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSkalaNyeri { get; set; }
        public byte[] ImgSkalaNyeri { get; set; }
        public string NamaImgSignPerawat1 { get; set; }
        public byte[] ImgSignPerawat1 { get; set; }
        public string NamaImgSignPerawat2 { get; set; }
        public byte[] ImgSignPerawat2 { get; set; }




        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
