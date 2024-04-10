﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class TRL38
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string UrutReporting { get; set; }

        public int KodeRL38 { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Jumlah { get; set; }

        public int IsIsi { get; set; }
    }
}
