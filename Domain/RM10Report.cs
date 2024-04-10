using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM10Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPetugasPenerima { get; set; }
        public byte[] ImgSignPetugasPenerima { get; set; }
        public string NamaImgSignPetugasPemberi { get; set; }
        public byte[] ImgSignPetugasPemberi { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM10 { get; set; }
        public virtual RM10 RM10 { get; set; }

    }
}
