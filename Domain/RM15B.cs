using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM15B
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string Evaluasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeFormulirGizi { get; set; }
        public virtual RM15A RM15A { get; set; }

        public int KodeNipPetugas { get; set; }
        public virtual TPegawai TPegawaiPetugas { get; set; }
    }
}
