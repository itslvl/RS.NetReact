using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RTindakan3
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(500)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Harga { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Dokter { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Harga2 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Dokter2 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Harga3 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Dokter3 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Harga4 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Dokter4 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Harga5 { get; set; }

        [DefaultValue(0.0)]
        [Required]
        public decimal Dokter5 { get; set; }

        [DefaultValue(0)]
        public int IsDokter { get; set; }

        [DefaultValue(0)]
        public int IsPA { get; set; }

        [DefaultValue(0)]
        public int IsKultur { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string Keterangan { get; set; }

        [MaxLength(10000)]
        [DefaultValue("")]
        public string Kesimpulan { get; set; }

        //FK
        public int KodeTindakan2 { get; set; }
        public virtual RTindakan2 RTindakan2 { get; set; }
        public int KodeInaCBG52 { get; set; }
        public virtual RInaCBG52 RInaCBG52 { get; set; }

        //PK
        public ICollection<RTindakan4> LstRTindakan4 { get; set; }
        public ICollection<RRL37A> LstRRL37A { get; set; }
        public ICollection<RRL38A> LstRRL38A { get; set; }
        public ICollection<TTindakan2> LstTTindakan2 { get; set; }
        public ICollection<TBayarSelisih> LstTBayarSelisih { get; set; }
        public ICollection<TRequestLabDt> LstTRequestLabDt { get; set; }
        public ICollection<TRequestRadiologiDt> LstTRequestRadiologiDt { get; set; }

        public ICollection<THonorDt> LstTHonorDt { get; set; }

    }
}
