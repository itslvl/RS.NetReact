using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM22Report
    {
        [Key]
        public int Kode { get; set; }

        
        public string NamaImgSignDokter { get; set; }
        public byte[] ImgSignDokter { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public byte[] ImgSignPerawat { get; set; }
        public string NamaImgSignPasien { get; set; }
        public byte[] ImgSignPasien { get; set; }
        public string NamaImgSignKeluargaPasien { get; set; }
        public byte[] ImgSignKeluargaPasien { get; set; }
        



        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
