using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM30Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignDokterAnastesi { get; set; }
        public byte[] ImgSignDokterAnastesi { get; set; }
        public string NamaImgSignPerawatAnastesi { get; set; }
        public byte[] ImgSignPerawatAnastesi { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM30 { get; set; }
        public virtual RM30 RM30 { get; set; }

    }
}
