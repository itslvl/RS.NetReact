using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TKonsinyasiDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty1 { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty2 { get; set; }

        [DefaultValue(0)]
        public int Konversi { get; set; }


        //FK
        public int KodeKonsinyasi { get; set; }
        public virtual TKonsinyasi TKonsinyasi { get; set; }

        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
    }
}
