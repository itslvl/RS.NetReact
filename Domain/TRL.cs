using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class TRL
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(0)]
        public int RL31 { get; set; }

        [DefaultValue(0)]
        public int RL32 { get; set; }

        [DefaultValue(0)]
        public int RL32Rujukan { get; set; }

        [DefaultValue(0)]
        public int RL32NonRujukan { get; set; }

        [DefaultValue(0)]
        public int RL32Dirawat { get; set; }

        [DefaultValue(0)]
        public int RL32Dirujuk { get; set; }

        [DefaultValue(0)]
        public int RL32Pulang { get; set; }

        [DefaultValue(0)]
        public int RL32IGD { get; set; }

        [DefaultValue(0)]
        public int RL32DOA { get; set; }

        [DefaultValue(0)]
        public int RL32Batal { get; set; }

        [DefaultValue(0)]
        public int RL33 { get; set; }

        [DefaultValue(0)]
        public int RL34 { get; set; }

        [DefaultValue(0)]
        public int RL34RS { get; set; }

        [DefaultValue(0)]
        public int RL34Bidan { get; set; }

        [DefaultValue(0)]
        public int RL34Puskesmas { get; set; }

        [DefaultValue(0)]
        public int RL34Faskes { get; set; }

        [DefaultValue(0)]
        public int RL34NonMedis { get; set; }

        [DefaultValue(0)]
        public int RL34NonRujukan { get; set; }

        [DefaultValue(0)]
        public int RL34Dirujuk { get; set; }

        [DefaultValue(0)]
        public int RL35 { get; set; }

        [DefaultValue(0)]
        public int RL35RS { get; set; }

        [DefaultValue(0)]
        public int RL35Bidan { get; set; }

        [DefaultValue(0)]
        public int RL35Puskesmas { get; set; }

        [DefaultValue(0)]
        public int RL35Faskes { get; set; }

        [DefaultValue(0)]
        public int RL35NonMedis { get; set; }

        [DefaultValue(0)]
        public int RL35NonRujukan { get; set; }

        [DefaultValue(0)]
        public int RL35Dirujuk { get; set; }

        [DefaultValue(0)]
        public int RL36 { get; set; }

        [DefaultValue(0)]
        public int RL36Khusus { get; set; }

        [DefaultValue(0)]
        public int RL36Besar { get; set; }

        [DefaultValue(0)]
        public int RL36Sedang { get; set; }

        [DefaultValue(0)]
        public int RL36Kecil { get; set; }

        [DefaultValue(0)]
        public int RL310 { get; set; }

        [DefaultValue(0)]
        public int RL311 { get; set; }

        [DefaultValue(0)]
        public int RL312 { get; set; }

        [DefaultValue(0)]
        public int RL312KonselingANC { get; set; }

        [DefaultValue(0)]
        public int RL312KonselingPascaPersalinan { get; set; }

        [DefaultValue(0)]
        public int RL312NonRujukan { get; set; }

        [DefaultValue(0)]
        public int RL312RujukanInap { get; set; }

        [DefaultValue(0)]
        public int RL312RujukanJalan { get; set; }

        [DefaultValue(0)]
        public int RL312Ulang { get; set; }

        [DefaultValue(0)]
        public int RL312PascaPersalinan { get; set; }

        [DefaultValue(0)]
        public int RL312Abortus { get; set; }

        [DefaultValue(0)]
        public int RL312Lainnya { get; set; }

        [DefaultValue(0)]
        public int RL312Ada { get; set; }

        [DefaultValue(0)]
        public int RL312TidakAda { get; set; }

        [DefaultValue(0)]
        public int RL312Dirujuk { get; set; }

        [DefaultValue(0)]
        public int RL314 { get; set; }

        [DefaultValue(0)]
        public int RL314TerimaPuskesmas { get; set; }

        [DefaultValue(0)]
        public int RL314TerimaFaskes { get; set; }

        [DefaultValue(0)]
        public int RL314TerimaRS { get; set; }

        [DefaultValue(0)]
        public int RL314KembaliPuskesmas { get; set; }

        [DefaultValue(0)]
        public int RL314KembaliFaskes { get; set; }

        [DefaultValue(0)]
        public int RL314KembaliRS { get; set; }

        [DefaultValue(0)]
        public int RL314Dirujuk { get; set; }

        [DefaultValue(0)]
        public int RL314Sendiri { get; set; }

        [DefaultValue(0)]
        public int RL314Kembali { get; set; }

        [DefaultValue(0)]
        public int RL52 { get; set; }

        [DefaultValue(0)]
        public int RL54KasusBaruY { get; set; }

        [DefaultValue(0)]
        public int RL54KasusBaruT { get; set; }




        [DefaultValue(0)]
        public int UmurTahun { get; set; }

        [DefaultValue(0)]
        public int UmurBulan { get; set; }

        [DefaultValue(0)]
        public int UmurHari { get; set; }

        [DefaultValue(0)]
        public int LamaInap { get; set; }

        [DefaultValue(0)]
        public int KodeIcd { get; set; }

        [DefaultValue(0)]
        public int KodeUmur { get; set; }

        

        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
        public int KodePasien { get; set; }
        public virtual TPasien TPasien { get; set; }
        public virtual RICD RICD { get; set; }
        public virtual RUmur RUmur { get; set; }

        [DefaultValue(0)]
        public int KodeCaraPulang { get; set; }
        public virtual RCaraPulang RCaraPulang { get; set; }

        [DefaultValue(0)]
        public int KodeIcd9 { get; set; }
        public virtual RICD9 RICD9 { get; set; }
    }
}
