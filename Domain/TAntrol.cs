using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DotNet.RS.Models
{
    public class TAntrol
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NomorAntrean { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string AngkaAntrean { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KodeBooking { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NoRm { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NamaPoli { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NamaDokter { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string EstimasiDilayani { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SisaKuotaJkn { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KuotaJkn { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SisaKuotaNonJkn { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string KuotaNonJkn { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Keterangan { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string SisaAntrian { get; set; }
        
        public DateTime Tanggal { get; set; }


    }
}
