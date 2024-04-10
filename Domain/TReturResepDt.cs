using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TReturResepDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0.00)]
        public decimal Harga { get; set; }

        [DefaultValue(0.00)]
        public decimal Kali { get; set; }

        [DefaultValue(0.00)]
        public decimal ResepKali { get; set; }

        public decimal Jumlah
        {
            get
            {
                return (Harga * Kali);
            }
            set { }
        }

        [DefaultValue(0.00)]
        public decimal Diskon { get; set; }

        public decimal Total
        {
            get
            {
                return ((Harga * Kali) - Diskon);
            }
            set { }
        }

        [DefaultValue(0.00)]
        public decimal Kronis { get; set; }

        [DefaultValue(0.00)]
        public decimal ResepKronis { get; set; }
        
        public decimal JumlahKronis
        {
            get
            {
                return (Harga * Kronis);
            }
            set { }
        }

        [DefaultValue(0.00)]
        public decimal DiskonKronis { get; set; }

        public decimal TotalKronis
        {
            get
            {
                return ((Harga * Kronis) - DiskonKronis);
            }
            set { }
        }

        //FK
        public int KodeReturResep { get; set; }
        public virtual TReturResep TReturResep { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
        public int NIP { get; set; }
        public virtual TPegawai TPegawai { get; set; }
    }
}
