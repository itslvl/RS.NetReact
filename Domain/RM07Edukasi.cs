using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM07Edukasi
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Edukasi { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Media { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Metode { get; set; }

        public DateTime? TanggalUlang { get; set; }

        [MaxLength(200)]
        [DefaultValue("")]
        [Required]
        public string NamaKeluarga { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM07 { get; set; }
        public virtual RM07 RM07 { get; set; }

        public int KodeNipEdukator { get; set; }
        public virtual TPegawai TPegawai { get; set; }
    }
}
