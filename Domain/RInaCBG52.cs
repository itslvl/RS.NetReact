using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RInaCBG52
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue("")]
        [MaxLength(255)]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        public ICollection<RLogistik> LstLogistik { get; set; }
        public ICollection<RTindakan3> LstRTindakan3 { get; set; }
    }
}