using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM32
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Informasi { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public string NamaImgSignPemberiInformasi { get; set; }
        public string NamaImgSignPenerimaInformasi { get; set; }






        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeJabatan { get; set; }
        public virtual RJabatan RJabatan { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public virtual TPegawai TPegawaiPemberiInformasi { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }


        //PK
        public ICollection<RM32Report> LstRM32Report { get; set; }


    }
}
