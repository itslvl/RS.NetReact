using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
   
    public class TRegistrasiBed
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Tanggal { get; set; }



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }
        
        public int KodeRuang5 { get; set; }
        public virtual RRuang5 RRuang5 { get; set; }
        
    }
}
