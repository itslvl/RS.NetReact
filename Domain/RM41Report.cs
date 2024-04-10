using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM41Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgSignPerawatOK { get; set; }
        public byte[] ImgSignPerawatOK { get; set; }
        public string NamaImgSignPerawatRuangan { get; set; }
        public byte[] ImgSignPerawatRuangan { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM41 { get; set; }
        public virtual RM41 RM41 { get; set; }

    }
}
