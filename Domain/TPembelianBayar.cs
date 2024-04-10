using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TPembelianBayar
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0.00)]
        public decimal Bayar { get; set; }

        [DefaultValue("")]
        public string Uraian { get; set; }

        //FK
        public int KodePembelian { get; set; }
        public virtual TPembelian TPembelian { get; set; }
    }
}
