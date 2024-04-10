using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM23ObatPulang
    {
        [Key]
        public int Kode { get; set; }        

        [DefaultValue(0)]
        public decimal Jumlah { get; set; }        

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Frekuensi { get; set; }        

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRM23 { get; set; }
        public virtual RM23 RM23 { get; set; }

        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }

        public int KodeDosis { get; set; }
        public virtual RDosis RDosis { get; set; }

        public int KodeCaraPakai { get; set; }
        public virtual RCaraPakai RCaraPakai { get; set; }

    }
}
