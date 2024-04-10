using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TGudang
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Uraian { get; set; }

        [DefaultValue(0.00)]
        public decimal Jumlah { get; set; }

        [DefaultValue(0.00)]
        public decimal MinStock { get; set; }

        [DefaultValue(0)]
        public int IsOrder { get; set; }

        [DefaultValue(0)]
        public int IsShow { get; set; }

        [DefaultValue(0.00)]
        public decimal SaldoAwal { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglTutup { get; set; }

        //FK
        public int KodeRuang3 { get; set; }
        public RRuang3 RRuang3 { get; set; }
        public int KodeLogistik { get; set; }
        public RLogistik RLogistik { get; set; }

        //PK
        public ICollection<TTutupStok> LstTTutupStok { get; set; }
    }
}
