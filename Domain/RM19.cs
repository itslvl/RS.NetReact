using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM19
    {
        [Key]
        public int Kode { get; set; }
        
        public DateTime Tanggal { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        [Required]
        public string Informasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }

        public int KodeNipPetugas { get; set; }
        public virtual TPegawai TPegawaiPetugas { get; set; }

    }
}
