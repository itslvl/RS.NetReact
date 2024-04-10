using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RDosis
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
        public ICollection<TResepDt> LstTResepDt { get; set; }
        public ICollection<TRequestResepDt> LstTRequestResepDt { get; set; }

        public ICollection<RM23ObatPulang> LstRM23ObatPulang { get; set; }

        public ICollection<RM22Obat> LstRM22Obat { get; set; }
    }
}
