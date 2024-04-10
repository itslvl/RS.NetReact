using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM37Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignInPerawat { get; set; }
        public byte[] ImgSignInPerawat { get; set; }
        public string NamaImgSignTimeOutPerawat { get; set; }
        public byte[] ImgSignTimeOutPerawat { get; set; }
        public string NamaImgSignOutPerawat { get; set; }
        public byte[] ImgSignOutPerawat { get; set; }
        public string NamaImgSignOutDokterBedah { get; set; }
        public byte[] ImgSignOutDokterBedah { get; set; }
        public string NamaImgSignOutDokterAnastesi { get; set; }
        public byte[] ImgSignOutDokterAnastesi { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM37 { get; set; }
        public virtual RM37 RM37 { get; set; }

    }
}
