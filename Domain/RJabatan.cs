﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RJabatan
    {

        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int PointJabatan { get; set; }

        [DefaultValue(0)]
        public int PointResikoKerja { get; set; }

        [DefaultValue(0)]
        public int PointDisiplin { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        public ICollection<TPegawai> LstTPegawai { get; set; }

        public ICollection<RM05> LstRM05 { get; set; }

        public ICollection<RM17> LstRM17 { get; set; }

        public ICollection<RM28> LstRM28 { get; set; }
        public ICollection<RM32> LstRM32 { get; set; }






    }
}