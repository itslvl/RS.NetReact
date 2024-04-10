﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace DotNet.RS.Models
{
    public class RM35Penyulit
    {
        [Key]
        public int Kode { get; set; }

        public string Uraian { get; set; }



        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM35 { get; set; }
        public virtual RM35 RM35 { get; set; }
    }
}
