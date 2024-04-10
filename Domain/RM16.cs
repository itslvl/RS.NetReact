using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM16
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosa { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Tujuan { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Intervensi { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Implementasi { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Evaluasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

    }
}
