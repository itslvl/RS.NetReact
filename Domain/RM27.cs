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
    public class RM27
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public string Catatan { get; set; }
        public string NamaImgPenanda { get; set; }
        public string NamaImgSignPerawat { get; set; }
        public string NamaImgSignPasien { get; set; }
        public string NamaImgSignDokter { get; set; }


        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNipDokter { get; set; }
        public virtual TPegawai TPegawaiDokter { get; set; }

        public int KodeNipPerawat { get; set; }
        public virtual TPegawai TPegawaiPerawat { get; set; }

                
        //PK
        public ICollection<RM27Report> LstRM27Report { get; set; }
    }
}
