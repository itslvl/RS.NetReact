using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM12AReport
    {
        [Key]
        public int Kode { get; set; }

        
        public string NamaImgLokasiLuka { get; set; }
        public byte[] ImgLokasiLuka { get; set; }
        public string NamaImgSkalaNyeri { get; set; }
        public byte[] ImgSkalaNyeri { get; set; }
        public string NamaImgSignPerawatPembuat { get; set; }
        public byte[] ImgSignPerawatPembuat { get; set; }
        public string NamaImgSignPerawatPelengkap { get; set; }
        public byte[] ImgSignPerawatPelengkap { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
