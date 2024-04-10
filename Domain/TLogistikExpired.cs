using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TLogistikExpired
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

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DefaultValue(1)]
        public int ApproveBy { get; set; }

        [DefaultValue("")]
        public string ApproveSign { get; set; }


        //FK
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
        public int NIPTerima { get; set; }
        public virtual TPegawai TPegawai { get; set; }

        //PK
        public ICollection<TLogistikExpiredDt> LstTLogistikExpiredDt { get; set; }
    }
}
