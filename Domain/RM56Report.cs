using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM56Report
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
        public int KodeRM56 { get; set; }
        public virtual RM56 RM56 { get; set; }

    }
}
