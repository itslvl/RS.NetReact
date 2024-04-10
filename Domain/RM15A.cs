using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class RM15A
    {
        [Key]
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }        

        [MaxLength(5000)]
        [DefaultValue("")]
        [Required]
        public string DiagnosaMasuk { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string BB { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string TB { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string IMT { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string TinggiLutut { get; set; }

        [MaxLength(10)]
        [DefaultValue("")]
        [Required]
        public string LLA { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string BioKimia { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Fisik { get; set; }

        [DefaultValue(0)]
        public int AlergiTelur { get; set; }

        [DefaultValue(0)]
        public int AlergiSusuSapi { get; set; }

        [DefaultValue(0)]
        public int AlergiKacang { get; set; }

        [DefaultValue(0)]
        public int AlergiGluten { get; set; }

        [DefaultValue(0)]
        public int AlergiUdang { get; set; }

        [DefaultValue(0)]
        public int AlergiIkan { get; set; }

        [DefaultValue(0)]
        public int AlergiHazelnut { get; set; }
        
        [MaxLength(5000)]
        [DefaultValue("")]
        public string PolaMakan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string RiwayatPersonal { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string PerhitunganKebutuhan { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string DiagnosaGizi { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string IntervensiGizi { get; set; }

        [MaxLength(5000)]
        [DefaultValue("")]
        public string Monitoring { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }


        
        //PK
        public ICollection<RM15B> LstRM15B { get; set; }
        public ICollection<RM15C> LstRM15C { get; set; }
    }
}
