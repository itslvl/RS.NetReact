using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RRL37A
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeRL37 { get; set; }
        public virtual RRL37 RRL37 { get; set; }
        public int KodeTindakan3Radiologi { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set; }
    }
}
