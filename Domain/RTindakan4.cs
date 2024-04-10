using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RTindakan4
    {
        [Key]
        public int Kode { get; set; }

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

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DefaultValue(1)]
        public int IsIsi { get; set; }

        //FK
        public int KodeTindakan3 { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set; }

        //PK
        public ICollection<TLaboratoriumDt> LstTLaboratoriumDt { get; set; }
    }
}
