using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RRuang3
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }
                
        [DefaultValue(1)]
        public int Lantai { get; set; }

        [DefaultValue(0)]
        public int IsInap { get; set; }

        [DefaultValue(0)]
        public int IsPenunjang { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Inisial { get; set; }

        [DefaultValue("")]
        public string SSCode { get; set; }

        //FK
        public int KodeRuang2 { get; set; }
        public virtual RRuang2 RRuang2 { get; set; }
        public int KodePoliBPJS { get; set; }
        public virtual RPoliBPJS RPoliBPJS { get; set; }
        public int KodeNipKepalaRuangan { get; set; }
        //public virtual TPegawai TPegawai { get; set; }

        //PK
        public ICollection<RRuang4> LstRuang4 { get; set; }
        public ICollection<TPegawai> LstPegawai { get; set; }
        public ICollection<TGudang> LstTGudang { get; set; }
        public ICollection<TPembelian> LstTPembelian { get; set; }

        [InverseProperty("RRuang3KodeDari")]
        public ICollection<TMutasi> LstTMutasiRuangDari { get; set; }
        [InverseProperty("RRuang3KodeKe")]
        public ICollection<TMutasi> LstTMutasiRuangKe { get; set; }

        //[InverseProperty("RRuang3Kode1")]
        //public ICollection<TMutasi> LstTMutasiRuang1 { get; set; }
        //[InverseProperty("RRuang3Kode2")]
        //public ICollection<TMutasi> LstTMutasiRuang2 { get; set; }

        [InverseProperty("RRuang3KodeFarmasi")]
        public ICollection<TResep> LstTResepKodeFarmasi { get; set; }
        [InverseProperty("RRuang3")]
        public ICollection<TResep> LstTResepKodeRuang { get; set; }
        public ICollection<TReturPembelian> LstTReturPembelian { get; set; }

        //[InverseProperty("RRuang3Kode1")]
        //public ICollection<TReturMutasi> LstTReturMutasiRuang1 { get; set; }
        //[InverseProperty("RRuang3Kode2")]
        //public ICollection<TReturMutasi> LstTReturMutasiRuang2 { get; set; }

        [InverseProperty("RRuang3")]
        public ICollection<TTindakan1> LstTTindakan1 { get; set; }
        [InverseProperty("RRuang3Trans")]
        public ICollection<TTindakan1> LstTTindakan1Trans { get; set; }


        [InverseProperty("RRuang3KodeFarmasi")]
        public ICollection<TReturResep> LstTReturResepKodeFarmasi { get; set; }
        [InverseProperty("RRuang3")]
        public ICollection<TReturResep> LstTReturResepKodeRuang { get; set; }

        public ICollection<TLogistikExpired> LstTLogistikExpired { get; set; }
        public ICollection<TLogistikOperasional> LstTLogistikOperasional { get; set; }

        public ICollection<TKonsinyasi> LstTKonsinyasi { get; set; }

        public ICollection<TBayarSelisih> LstTBayarSelisih { get; set; }

        public ICollection<RM01A> LstRM01A { get; set; }
        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM04> LstRM04 { get; set; }
        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }
        [InverseProperty("RRuang3Awal")]
        public ICollection<RM10> LstRM10Ruang3Awal { get; set; }
        [InverseProperty("RRuang3Akhir")]
        public ICollection<RM10> LstRM10Ruang3Akhir { get; set; }

        public ICollection<RM23> LstRM23 { get; set; }

        public ICollection<RM25> LstRM25 { get; set; }
        public ICollection<RM30> LstRM30 { get; set; }
        public ICollection<RM36> LstRM36 { get; set; }
        public ICollection<RM39> LstRM39 { get; set; }
        public ICollection<RM40> LstRM40 { get; set; }
        public ICollection<RM41> LstRM41 { get; set; }

        [InverseProperty("RRuang3")]
        public ICollection<RM45> LstRM45Ruang3 { get; set; }
        [InverseProperty("RRuang31")]
        public ICollection<RM45> LstRM45Ruang31 { get; set; }
        [InverseProperty("RRuang32")]
        public ICollection<RM45> LstRM45Ruang32 { get; set; }

        public ICollection<RM58> LstRM58 { get; set; }
        public ICollection<RM65> LstRM65 { get; set; }



        [InverseProperty("RRuang3KodeRuang3Request")]
        public ICollection<TRequestResep> LstTRequestResepRuang3Request { get; set; }
        [InverseProperty("RRuang3KodeRuang3Farmasi")]
        public ICollection<TRequestResep> LstTRequestResepRuang3Farmasi { get; set; }

        [InverseProperty("RRuang3KodeRuang3Request")]
        public ICollection<TRequestLab> LstTRequestLabRuang3Request { get; set; }
        [InverseProperty("RRuang3KodeRuang3Laboratorium")]
        public ICollection<TRequestLab> LstTRequestLabRuang3Lab { get; set; }

        [InverseProperty("RRuang3KodeRuang3Request")]
        public ICollection<TRequestRadiologi> LstTRequestRadiologiRuang3Request { get; set; }
        [InverseProperty("RRuang3KodeRuang3Radiologi")]
        public ICollection<TRequestRadiologi> LstTRequestRadiologiRuang3Radiologi { get; set; }


    }
}
