using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RM22Obat
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Indikasi { get; set; }
        
        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string WaktuMinum { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //FK
        public int KodeRM22 { get; set; }
        public virtual RM22 RM22 { get; set; }

        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }

        public int KodeDosis { get; set; }
        public virtual RDosis RDosis { get; set; }

        public int KodeCaraPakai { get; set; }
        public virtual RCaraPakai RCaraPakai { get; set;}




    }
}
