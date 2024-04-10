using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TBayarSelisih
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public DateTime Tanggal { get; set; }

        public decimal Kali { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public decimal Harga1 { get; set; }


        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public decimal Tambah1 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal? Jumlah1
        {
            get { return ((Kali * Harga1) + Tambah1); }
            set { }
        }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal Diskon1 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal? Total1
        {
            get { return ((Kali * Harga1) + Tambah1 - Diskon1); }
            set { }
        }

        //untuk dokter
        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal Harga2 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal Tambah2 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal? Jumlah2
        {
            get { return ((Kali * Harga2) + Tambah2); }
            set { }
        }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal Diskon2 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal? Total2
        {
            get { return ((Kali * Harga2) + Tambah2 - Diskon1); }
            set { }
        }








        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRTindakan3 { get; set; }
        [JsonIgnore]
        public virtual RTindakan3 RTindakan3 { get; set; }

        public int KodeDokter { get; set; }
        public virtual TPegawai TPegawai { get; set; }

        public int KodeRuang3Trans { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
    }
}
