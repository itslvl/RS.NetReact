using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM29Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }
        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignSaksiRS { get; set; }
        public byte[] ImgSignSaksiRS { get; set; }
        public string NamaImgSignSaksiPasien { get; set; }
        public byte[] ImgSignSaksiPasien { get; set; }

        
        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM29 { get; set; }
        public virtual RM29 RM29 { get; set; }

    }
}
