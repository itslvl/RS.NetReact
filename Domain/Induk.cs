using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class Induk
    {
        [Key]
        public int Kode { get; set; }
        public string Uraian { get; set; }

        public ICollection<Anak> KodeIndukNav { get; set; }
        public ICollection<Anak> KodeInduk2Nav { get; set; }
    }
}
