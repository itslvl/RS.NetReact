using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TLogistikOperasionalDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglOperasional { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        //FK
        public int KodeLogistikOperasional { get; set; }
        public virtual TLogistikOperasional TLogistikOperasional { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
    }
}
