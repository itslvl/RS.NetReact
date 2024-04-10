using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM06Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgWorgBakers { get; set; }
        public byte[] ImgWorgBakers { get; set; }
        public string NamaImgPria { get; set; }
        public byte[] ImgPria { get; set; }
        public string NamaImgWanita { get; set; }
        public byte[] ImgWanita { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public byte[] ImgSignPerawat { get; set; }
        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
