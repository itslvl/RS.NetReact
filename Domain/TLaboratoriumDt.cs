using DotNet.RS.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TLaboratoriumDt
    {
        [Key]
        public int Kode { get; set; }
        public int Deleted { get; set; }        

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Satuan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Rujukan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Metode { get; set; }

        [DefaultValue(0)]
        public int Grup { get; set; }

        [DefaultValue(1)]
        public int IsIsi { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Hasil { get; set; }

        //FK
        public int KodeTTindakan2 { get; set; }
        public virtual TTindakan2 TTindakan2 { get; set; }

        public int KodeRTindakan4 { get; set; }
        public virtual RTindakan4 RTindakan4 { get; set; }

    }
}
