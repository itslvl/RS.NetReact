using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RTindakanRM
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }


        //PK
        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }

        public ICollection<RM24> LstRM24 { get; set; }
        public ICollection<RM25> LstRM25 { get; set; }
        public ICollection<RM30> LstRM30 { get; set; }
        public ICollection<RM36> LstRM36 { get; set; }
        public ICollection<RM37> LstRM37 { get; set; }



    }
}
