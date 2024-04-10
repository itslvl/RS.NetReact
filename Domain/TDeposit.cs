using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TDeposit
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public DateTime Tanggal { get; set; }

        [DefaultValue("")]
        [MaxLength(254)]
        public string Uraian { get; set; }

        [DefaultValue(0.00)]
        public decimal Deposit { get; set; }





        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodePegawaiKasir { get; set; }
        public virtual TPegawai TPegawaiKasir { get; set; }

        public int KodePegawaiEdit { get; set; }
        public virtual TPegawai TPegawaiEdit { get; set; }

        public int KodePegawaiHapus { get; set; }
        public virtual TPegawai TPegawaiHapus { get; set; }


    }
}
