using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TKonsinyasi
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [DefaultValue("")]
        public string Catatan { get; set; }

        [DefaultValue(0)]
        public int IsTerima { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglTerima { get; set; }

        [DefaultValue(1)]
        public int ApproveBy { get; set; }

        [DefaultValue("")]
        public string ApproveSign { get; set; }

        [DefaultValue(0)]
        public int KodeRetur { get; set; }

        [DefaultValue(0)]
        public int IsRetur { get; set; }



        //FK
        public int NIPTerima { get; set; }
        public virtual TPegawai TPegawaiKonsinyasiTerima { get; set; }

        public int NIPRequest { get; set; }
        public virtual TPegawai TPegawaiKonsinyasiRequest { get; set; }

        public int KodeSupplier { get; set; }
        public virtual RSupplier RSupplier { get; set; }

        [DefaultValue(0)]
        public int KodeRuang3 { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }

        //PK
        public ICollection<TKonsinyasiDt> LstKonsinyasiDt { get; set; }
    }
}
