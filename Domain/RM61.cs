using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM61
    {
        [Key]
        public int Kode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tanggal { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string PotonganTubuh { get; set; }

        [MaxLength(50)]
        [DefaultValue("")]
        [Required]
        public string Hari { get; set; }

        [DataType(DataType.Date)]
        public DateTime TglOperasi { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string NamaPenerima { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        public string NamaImgSignDokter { get; set; }
        public string NamaImgSignPetugasPemberi { get; set; }
        public string NamaImgSignPenerima { get; set; }



        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipYangMenyerahkan { get; set; }
        public virtual TPegawai TPegawaiYangMenyerahkan { get; set; }

        public int KodeNipDpjp { get; set; }
        public virtual TPegawai TPegawaiDpjp { get; set; }

        //PK
        public ICollection<RM61Report> LstRM61Report { get; set; }

    }
}
