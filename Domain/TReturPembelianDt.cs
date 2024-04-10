using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TReturPembelianDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglExpired { get; set; }

        [DefaultValue(0.00)]
        public decimal JumlahBeli { get; set; }
                
        [DefaultValue(0.00)]
        public decimal Qty1Beli { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty2Beli { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty1 { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty2 { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DefaultValue(0)]
        public int Konversi { get; set; }

        //FK
        public int KodeReturPembelian { get; set; }
        public virtual TReturPembelian TReturPembelian { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
    }
}