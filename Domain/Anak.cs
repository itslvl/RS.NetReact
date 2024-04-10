using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class Anak
    {
        [Key]
        public int Kode { get; set; }
        public string Uraian { get; set; }
        public int KodeInduk { get; set; }
        public int KodeInduk2 { get; set; }
        public Induk KodeIndukKeAnak { get; set; }
        public Induk KodeInduk2KeAnak { get; set; }
    }
}
