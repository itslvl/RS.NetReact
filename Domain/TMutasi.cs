using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TMutasi
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Tanggal { get; set; }
        
        [DefaultValue(0)]
        public int Referensi { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Catatan { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglTerima { get; set; }

        //FK
        //public int KodeRMutasi { get; set; }
        //public virtual RMutasi RMutasi { get; set; }
        //public int KodeRuang1 { get; set; }
        //public virtual RRuang3 RRuang3Kode1 { get; set; }
        //public int KodeRuang2 { get; set; }
        //public virtual RRuang3 RRuang3Kode2 { get; set; }

        public int KodeRuang3Dari { get; set; }
        public virtual RRuang3 RRuang3KodeDari { get; set; }
        public int KodeRuang3Ke { get; set; }
        public virtual RRuang3 RRuang3KodeKe { get; set; }

        public int NIPTerima { get; set; }
        public virtual TPegawai TPegawaiNIPTerima { get; set; }
        public int NIPRequest { get; set; }
        public virtual TPegawai TPegawaiNIPRequest { get; set; }

        [DefaultValue(1)]
        public int ApproveBy { get; set; }

        [DefaultValue("")]
        public string ApproveSign { get; set; }

        //PK
        public ICollection<TMutasiDt> LstTMutasiDt { get; set; }
        //public ICollection<TReturMutasi> LstTReturMutasi { get; set; }
    }
}
