using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TTindakan1
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue("")]
        [MaxLength(254)]
        public string Uraian { get; set; }

        //Tidak digunakan kasir
        [DefaultValue("")]
        [MaxLength(254)]
        public string Uraian2 { get; set; }

        [DefaultValue(0)]
        public int NoRequest { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
                
        //Ke Ruang3
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        public int KodeDokter1 { get; set; }
        public virtual TPegawai TPegawaiDokter1 { get; set; }

        public int KodeDokter2 { get; set; }
        public virtual TPegawai TPegawaiDokter2 { get; set; }                      

        [DefaultValue(0)]
        public int KodeRuang3Trans { get; set; }
        public virtual RRuang3 RRuang3Trans { get; set; }



        //PK
        public ICollection<TTindakan2> LstTTindakan2 { get; set; }

    }
}
