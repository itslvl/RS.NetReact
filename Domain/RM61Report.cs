using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM61Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }
        public string NamaImgSignPetugasPemberi { get; set; }
        public byte[] ImgSignPetugasPemberi { get; set; }
        public string NamaImgSignPenerima { get; set; }
        public byte[] ImgSignPenerima { get; set; }
        


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM61 { get; set; }
        public virtual RM61 RM61 { get; set; }

    }
}
