using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM09Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignSaksi { get; set; }
        public byte[] ImgSignSaksi { get; set; }
        public string NamaImgSignPetugas { get; set; }
        public byte[] ImgSignPetugas { get; set; }
        

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM09 { get; set; }
        public virtual RM09 RM09 { get; set; }


    }
}
