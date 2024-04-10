using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class TRequestResepDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0.00)]
        public decimal Kali { get; set; }

        [DefaultValue(0.00)]
        public decimal Kronis { get; set; }

        [DefaultValue(0)]
        public int IsMakan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }





        //FK
        public int KodeRequestResep { get; set; }
        public virtual TRequestResep TRequestResep { get; set; }

        public int KodeLogistik { get; set; }
        public virtual RLogistik RLogistik { get; set; }

        public int KodeDosis { get; set; }
        public virtual RDosis RDosis { get; set; }
        
        public int KodeCaraPakai { get; set; }
        public virtual RCaraPakai RCaraPakai { get; set; }




    }
}
