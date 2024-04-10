using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TResepDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0.00)]
        public decimal Harga { get; set; }

        [DefaultValue(0.00)]
        public decimal Kali { get; set; }

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
                return ((Harga * Kali) - Diskon) ;
            }
            set { }
        }

        [DefaultValue(0)]
        public int IsOk { get; set; }

        [DefaultValue(0.00)]
        public decimal SisaYL { get; set; }

        [DefaultValue(0.00)]
        public decimal Kronis { get; set; }

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

        [MaxLength(255)]
        [DefaultValue("")]
        public string NB { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ED { get; set; }

        [DefaultValue(0)]
        public int IsMakan { get; set; }

        //FK
        public int KodeResep { get; set; }
        public virtual TResep TResep { get; set; }
        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }
        public int KodeDosis { get; set; }
        public virtual RDosis RDosis { get; set; }
        public int KodeCaraPakai { get; set; }
        public virtual RCaraPakai RCaraPakai { get; set; }
        public int NIP { get; set; }
        public virtual TPegawai TPegawai { get; set; }
    }
}
