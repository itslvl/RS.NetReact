using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TLogistikExpiredDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglExpired { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        //FK
        public int KodeLogistikExpired { get; set; }
        public virtual TLogistikExpired TLogistikExpired { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
    }
}
