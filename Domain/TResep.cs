using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TResep
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0)]
        public int IsRetur { get; set; }

        [DefaultValue(0)]
        public int IsFarmasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string Catatan { get; set; }
        public int NoRequest { get; set; }

        [DefaultValue(1)]
        public int IsJelas { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UJelas { get; set; }

        [DefaultValue(1)]
        public int IsLengkap { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string ULengkap { get; set; }

        [DefaultValue(1)]
        public int IsFarmasetis { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UFarmasetis { get; set; }

        [DefaultValue(1)]
        public int IsKlinis { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UKlinis { get; set; }

        [DefaultValue(1)]
        public int IsTPasien { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTPasien { get; set; }

        [DefaultValue(1)]
        public int IsTObat { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTObat { get; set; }

        [DefaultValue(1)]
        public int IsTDosis { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTDosis { get; set; }

        [DefaultValue(1)]
        public int IsTRute { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTRute { get; set; }

        [DefaultValue(1)]
        public int IsTWaktu { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTWaktu { get; set; }

        [DefaultValue(1)]
        public int IsTInformasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTInformasi { get; set; }

        [DefaultValue(1)]
        public int IsTDokumentasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsTDokumentasi { get; set; }

        [DefaultValue(1)]
        public int IsEfekSamping { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsEfekSamping { get; set; }

        [DefaultValue(1)]
        public int IsDuplikasi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsDuplikasi { get; set; }

        [DefaultValue(1)]
        public int IsInteraksi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsInteraksi { get; set; }

        [DefaultValue(1)]
        public int IsKontraIndikaksi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsKontraIndikasi { get; set; }

        [DefaultValue(1)]
        public int IsNamaObat { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsNamaObat { get; set; }

        [DefaultValue(1)]
        public int IsDosis { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsDosis { get; set; }

        [DefaultValue(1)]
        public int IsRute { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsRute { get; set; }

        [DefaultValue(1)]
        public int IsWaktu { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsWaktu { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TglTerima { get; set; }

        [DefaultValue(0)]
        public int IsRacik { get; set; }

        [DefaultValue(0)]
        public int IsPemberianObat { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsPemberianObat { get; set; }

        [DefaultValue(0)]
        public int IsResikoAlergi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsResikoAlergi { get; set; }

        [DefaultValue(0)]
        public int IsBeratBadan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        public string UIsBeratBadan { get; set; }

        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
        public int KodeFarmasi { get; set; }
        public virtual RRuang3 RRuang3KodeFarmasi { get; set; }
        public int KodeRuang { get; set; }
        public virtual RRuang3 RRuang3 { get; set; }
        public int KodeDokter { get; set; }
        public virtual TPegawai TPegawaiKodeDokter { get; set; }
        public int KodeApoteker { get; set; }
        public virtual TPegawai TPegawaiKodeApoteker { get; set; }

        //PK
        public ICollection<TResepDt> LstTResepDt { get; set; }
    }
}
