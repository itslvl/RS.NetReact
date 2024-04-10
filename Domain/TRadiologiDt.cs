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
    public class TRadiologiDt
    {
        [Key]
        public int Kode { get; set; }
        public int Deleted { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Keterangan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Kesimpulan { get; set; }

        //FK
        public int KodeTTindakan2 { get; set; }
        public virtual TTindakan2 TTindakan2 { get; set; }
    }
}
