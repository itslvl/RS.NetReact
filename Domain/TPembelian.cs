using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TPembelian
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Tanggal { get; set; }
        
        [MaxLength(255)]
        [DefaultValue("")]
        public string NoFaktur { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglFaktur { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglTempo { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string NoPesanan { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglPesanan { get; set; }

        [DefaultValue(0.00)]
        public decimal Total { get; set; }

        [DefaultValue(0.00)]
        public decimal Potongan { get; set; }

        [DefaultValue(0.00)]
        public decimal Dp { get; set; }

        [DefaultValue(0.00)]
        public decimal Bayar { get; set; }

        [DefaultValue(0.00)]
        public decimal Sisa 
        {
            get
            {
                return (Total + PPN) - (Potongan + Bayar);
            }
            set { }
        }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Catatan { get; set; }

        [DefaultValue(0.00)]
        public decimal PPN { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        //FK
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
        public int KodeSupplier { get; set; }
        public virtual RSupplier RSupplier { get; set; }
        public int NIPTerima { get; set; }
        public virtual TPegawai TPegawai { get; set; }

        [DefaultValue(1)]
        public int ApproveBy { get; set; }

        [DefaultValue("")]
        public string ApproveSign { get; set; }

        //PK
        public ICollection<TPembelianDt> LstTPembelianDt { get; set; }
        public ICollection<TPembelianBayar> LstTPembelianBayar { get; set; }
        public ICollection<TReturPembelian> LstTReturPembelian { get; set; }
    }
}
