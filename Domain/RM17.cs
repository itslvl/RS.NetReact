using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM17
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string KeteranganS { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string KeteranganO { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string KeteranganA { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string KeteranganP { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNip { get; set; }
        public virtual TPegawai TPegawai { get; set; }

        public int KodeJabatan { get; set; }
        public virtual RJabatan RJabatan { get; set; }

    }
}
