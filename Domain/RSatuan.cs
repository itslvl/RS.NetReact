using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RSatuan
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //PK
        [InverseProperty("RSatuan1")]
        public ICollection<RLogistik> LstLogistik1 { get; set; }

        [InverseProperty("RSatuan2")]
        public ICollection<RLogistik> LstLogistik2 { get; set; }
    }
}