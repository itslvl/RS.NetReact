using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM24Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }
        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignSaksi { get; set; }
        public byte[] ImgSignSaksi { get; set; }

        


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM24 { get; set; }
        public virtual RM24 RM24 { get; set; }

    }
}
