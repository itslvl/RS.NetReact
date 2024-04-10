using DotNet.RS.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain{
    public class TTindakan2
    {
        [Key]
        public int Kode { get; set; }

        public int Deleted { get; set; }

        public decimal Kali { get; set; }

        [DisplayFormat(DataFormatString = "{0:#.##}")]
        //[JsonConverter(typeof(DecimalJsonConverter))]
        public decimal Harga1 { get; set; }

        //[JsonConverter(typeof(DecimalJsonConverter))]
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

        public string NoReff { get; set; }




        //FK
        public int KodeTTindakan1 { get; set; }
        [JsonIgnore]
        public virtual TTindakan1 TTindakan1 { get; set; }

        public int KodeRTindakan3 { get; set; }
        [JsonIgnore]
        public virtual RTindakan3 RTindakan3 { get; set; }


        //PK
        public ICollection<TLaboratoriumDt> LstTLaboratoriumDt { get; set; }
        public ICollection<TRadiologiDt> LstTRadiologiDt { get; set; }
    }
}
