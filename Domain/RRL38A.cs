using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RRL38A
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeRL38 { get; set; }
        public virtual RRL38 RRL38 { get; set; }
        public int KodeTindakan3Lab { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set; }
    }
}
