using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM02Informasi
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int MemberiYa { get; set; }

        [DefaultValue(0)]
        public int MemberiTidak { get; set; }

        [MaxLength(100)]
        [DefaultValue("")]
        [Required]
        public string Nama { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        //FK
        public int KodeHubunganKeluarga { get; set; }
        public virtual RHubunganKeluarga RHubunganKeluarga { get; set; }

        public int KodeRM02 { get; set; }
        public virtual RM02 RM02 { get; set; }
    }
}