using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RLogistik
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0.0)]
        public decimal Konversi { get; set; }

        [DefaultValue(0.0)]
        public decimal Harga { get; set; }

        [DefaultValue(0.0)]
        public decimal Harga2 { get; set; }

        [DefaultValue(0.0)]
        public decimal Harga3 { get; set; }

        [DefaultValue(0.0)]
        public decimal Harga4 { get; set; }

        [DefaultValue(0.0)]
        public decimal Harga5 { get; set; }

        [DefaultValue(0.0)]
        public decimal Modal { get; set; }

        [DefaultValue(0.0)]
        public int IsAlert { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Barcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglUpdate { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeGrupLogistik { get; set; }
        public virtual RGrupLogistik RGrupLogistik { get; set; }
        public int KodeRL313 { get; set; }
        public virtual RRL313 RL313 { get; set; }
        public int KodeInaCBG52 { get; set; }
        public virtual RInaCBG52 RInaCBG52 { get; set; }
        public int KodeSatuan1 { get; set; }
        public virtual RSatuan RSatuan1 { get; set; }
        public int KodeSatuan2 { get; set; }
        public virtual RSatuan RSatuan2 { get; set; }
        
        //PK
        public ICollection<TGudang> LstTGudang { get; set; }
        public ICollection<TMutasiDt> LstTMutasiDt { get; set; }
        public ICollection<TPembelianDt> LstTPembelianDt { get; set; }
        public ICollection<TResepDt> LstTResepDt { get; set; }
        public ICollection<TReturPembelianDt> LstTReturPembelianDt { get; set; }
        //public ICollection<TReturMutasiDt> LstTReturMutasiDt { get; set; }
        public ICollection<TReturResepDt> LstTReturResepDt { get; set; }
        public ICollection<TLogistikExpiredDt> LstTLogistikExpiredDt { get; set; }
        public ICollection<TLogistikOperasionalDt> LstTLogistikOperasionalDt { get; set; }

        public ICollection<TKonsinyasiDt> LstKonsinyasiDt { get; set; }
        public ICollection<TRequestResepDt> LstTRequestResepDt { get; set; }

        public ICollection<RM23ObatRS> LstRM23ObatRS { get; set; }

        public ICollection<RM23ObatPulang> LstRM23ObatPulang { get; set; }

        public ICollection<RM22Obat> LstRM22Obat { get; set; }
    }
}