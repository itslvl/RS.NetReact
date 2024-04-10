using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TRequestResep
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Catatan { get; set; }

        [DefaultValue(0)]
        public int IsKirim { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DefaultValue(0)]
        public int IsNotif { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeDokterRequest { get; set; }
        public virtual TPegawai TPegawaiKodeDokterRequest { get; set; }

        public int KodePerawatRequest { get; set; }
        public virtual TPegawai TPegawaiKodePerawatRequest { get; set; }

        public int KodeRuang3Request { get; set; }
        public virtual RRuang3 RRuang3KodeRuang3Request { get; set; }

        public int KodeRuang3Farmasi { get; set; }
        public virtual RRuang3 RRuang3KodeRuang3Farmasi { get; set; }


        //PK
        public ICollection<TRequestResepDt> LstTRequestResepDt { get; set; }
    }
}
