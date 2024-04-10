using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM32Report
    {
        [Key]
        public int Kode { get; set; }

        public string NamaImgSignPemberiInformasi { get; set; }
        public byte[] ImgSignPemberiInformasi { get; set; }
        public string NamaImgSignPenerimaInformasi { get; set; }
        public byte[] ImgSignPenerimaInformasi { get; set; }


        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM32 { get; set; }
        public virtual RM32 RM32 { get; set; }




    }
}
