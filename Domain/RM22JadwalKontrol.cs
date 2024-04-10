using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM22JadwalKontrol
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Pemeriksaan { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TempatPemeriksaan { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string NoTelp { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM22 { get; set; }
        public virtual RM22 RM22 { get; set; }

    }
}
