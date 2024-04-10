using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TMutasiDt
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
        public int IsTerima { get; set; }

        [DefaultValue(0.00)]
        public decimal Konversi { get; set; }



        //FK
        public int KodeMutasi { get; set; }
        public virtual TMutasi TMutasi { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
        public int NIPTerima { get; set; }
        public virtual TPegawai TPegawai { get; set; }
    }
}
