using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TPembelianDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglExpired { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0.00)]
        public decimal HargaSatuan { get; set; }

        [DefaultValue(0.00)]
        public decimal Potongan { get; set; }

        [DefaultValue(0.00)]
        public decimal Total { get; set; }

        [DefaultValue(0.00)]
        public decimal Realisasi { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty1 { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty2 { get; set; }

        [DefaultValue(0.00)]
        public decimal Modal { get; set; }

        [DefaultValue(0.00)]
        public decimal PPN { get; set; }

        [DefaultValue(0.00)]
        public decimal PerPPN { get; set; }

        [DefaultValue(0.00)]
        public decimal Diskon { get; set; }

        [DefaultValue(0.00)]
        public decimal PerDiskon { get; set; }        

        [MaxLength(255)]
        [DefaultValue("")]
        public string BatchNumber { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DefaultValue(0)]
        public int Konversi { get; set; }

        //FK
        public int KodePembelian { get; set; }
        public virtual TPembelian TPembelian { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
    }
}
