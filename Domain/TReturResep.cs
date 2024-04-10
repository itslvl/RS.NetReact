using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TReturResep
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }
        
        [MaxLength(255)]
        [DefaultValue("")]
        public string Catatan { get; set; }
        public int NoResep { get; set; }

        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
        public int KodeFarmasi { get; set; }
        public virtual RRuang3 RRuang3KodeFarmasi { get; set; }
        public int KodeRuang { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
        public int KodeDokter { get; set; }
        public virtual TPegawai TPegawaiKodeDokter { get; set; }
        public int KodeApoteker { get; set; }
        public virtual TPegawai TPegawaiKodeApoteker { get; set; }

        //PK
        public ICollection<TReturResepDt> LstTReturResepDt { get; set; }
    }
}
