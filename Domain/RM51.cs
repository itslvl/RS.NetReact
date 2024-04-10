using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM51
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string TempatLahir { get; set; }

        [DefaultValue(0)]
        public int Umur { get; set; }

        [MaxLength(200)]
        [DefaultValue("")]
        [Required]
        public string Alamat { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaDokter { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string HasilPenunjang { get; set; }

        public DateTime Tanggal { get; set; }

        public DateTime TglPengembalian { get; set; }        

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public string NamaImgSignPetugas { get; set; }
        public string NamaImgSignSaksi { get; set; }
        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignPetugasKembali { get; set; }
        public string NamaImgSignPasienKembali { get; set; }


        //FK
        public int KodeJenisKelamin { get; set; }
        public virtual RJenisKelamin RJenisKelamin { get; set; }

        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeRsRujukan { get; set; }
        public virtual RRujukKeluar RRujukKeluar { get; set; }







    }
}
