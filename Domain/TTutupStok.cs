using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TTutupStok
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0.00)]
        public decimal Awal { get; set; }

        [DefaultValue(0.00)]
        public decimal Akhir { get; set; }                

        [DataType(DataType.DateTime)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int IsGabung { get; set; }


        //FK
        public int KodeLogistikGudang { get; set; }
        public virtual TGudang TGudang { get; set; }
        public int NIP { get; set; }
        public virtual TPegawai TPegawai { get; set; }
    }
}
