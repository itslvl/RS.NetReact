using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM23Pemeriksaan
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Pemeriksaan { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Hasil { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        public string Keterangan { get; set; }
        
        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRM23 { get; set; }
        public virtual RM23 RM23 { get; set; }
    }
}
