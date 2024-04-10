using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM02Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignSaksi1 { get; set; }
        public byte[] ImgSignSaksi1 { get; set; }
        public string NamaImgSignSaksi2 { get; set; }
        public byte[] ImgSignSaksi2 { get; set; }
        
        
        [DefaultValue(0)]
        public int Deleted { get; set; }

        
        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
