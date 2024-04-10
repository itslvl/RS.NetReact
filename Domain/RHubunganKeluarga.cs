using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RHubunganKeluarga
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Uraian { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //PK
        public ICollection<TRegistrasi> LstTRegistrasi { get; set; }

        public ICollection<RM02> LstRM02 { get; set; }
        public ICollection<RM02Informasi> LstRM02Informasi { get; set; }
        public ICollection<RM02Privasi> LstRM02Privasi { get; set; }
        public ICollection<RM03> LstRM03 { get; set; }
        public ICollection<RM05> LstRM05 { get; set; }
        public ICollection<RM08> LstRM08 { get; set; }
        public ICollection<RM09> LstRM09 { get; set; }


        public ICollection<RM12A> LstRM12A { get; set; }


        public ICollection<RM24> LstRM24 { get; set; }
        public ICollection<RM25> LstRM25 { get; set; }
        public ICollection<RM28> LstRM28 { get; set; }
        public ICollection<RM29> LstRM29 { get; set; }


        public ICollection<RM32> LstRM32 { get; set; }


        public ICollection<RM45> LstRM45 { get; set; }
        public ICollection<RM46> LstRM46 { get; set; }
        [InverseProperty("RHubunganKeluarga")]
        public ICollection<RM50> LstRM50HubunganKeluarga { get; set; }
        [InverseProperty("RHubunganDenganPasien")]
        public ICollection<RM50> LstRM50HubunganDenganPasien { get; set; }
        public ICollection<RM56> LstRM56 { get; set; }
        public ICollection<RM62> LstRM62 { get; set; }
        public ICollection<RM65> LstRM65 { get; set; }
    }
}
