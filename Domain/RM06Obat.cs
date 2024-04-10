﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM06Obat
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(200)]
        [DefaultValue("")]
        [Required]
        public string Obat { get; set; }

        [MaxLength(200)]
        [DefaultValue("")]
        [Required]
        public string Dosis { get; set; }

        [MaxLength(200)]
        [DefaultValue("")]
        [Required]
        public string Keterangan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM06 { get; set; }
        public virtual RM06 RM06 { get; set; }
    }
}
