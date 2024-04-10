using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM27Report
    {
        [Key]
        public int Kode { get; set; }


        public string NamaImgPenanda { get; set; }
        public byte[] ImgPenanda { get; set; }
        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public byte[] ImgSignPerawat { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM27 { get; set; }
        public virtual RM27 RM27 { get; set; }
    }
}
