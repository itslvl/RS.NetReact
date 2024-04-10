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
    public class RM07
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int TinggalAnak { get; set; }

        [DefaultValue(0)]
        public int TinggalOrangTua { get; set; }

        [DefaultValue(0)]
        public int TinggalSendiri { get; set; }

        [DefaultValue(0)]
        public int TinggalSuamiIstri { get; set; }

        [DefaultValue(0)]
        public int BahasaIndonesia { get; set; }

        [DefaultValue(0)]
        public int BahasaDaerah { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BahasaDaerahKeterangan { get; set; }

        [DefaultValue(0)]
        public int BahasaAsing { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        public string BahasaAsingKeterangan { get; set; }

        [DefaultValue(0)]
        public int PenerjemahYa { get; set; }

        [DefaultValue(0)]
        public int PenerjemahTidak { get; set; }

        [DefaultValue(0)]
        public int HambatanYa { get; set; }

        [DefaultValue(0)]
        public int HambatanTidak { get; set; }

        [DefaultValue(0)]
        public int GangguanPendengaran { get; set; }

        [DefaultValue(0)]
        public int GangguanEmosi { get; set; }

        [DefaultValue(0)]
        public int GangguanPenglihatan { get; set; }

        [DefaultValue(0)]
        public int HilangMemori { get; set; }

        [DefaultValue(0)]
        public int GangguanBicara { get; set; }

        [DefaultValue(0)]
        public int MotivasiBuruk { get; set; }

        [DefaultValue(0)]
        public int Fisiologis { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        public string PdfUrl { get; set; }

        [Display(Name = "Pdf")]
        [NotMapped]
        public IFormFile FilePdf { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }



        //PK
        public ICollection<RM07Edukasi> LstRM07Edukasi { get; set; }
    }
}
