using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class RICD
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(50)]
        [Required]
        [DefaultValue("")]
        public string KodeICD { get; set; }

        [MaxLength(255)]
        [Required]
        [DefaultValue("")]
        public string Uraian { get; set; }

        [MaxLength(255)]
        [Required]
        [DefaultValue("")]
        public string Uraian2 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int IsPenyakit { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL1 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL2 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL3 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL4 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL5 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL6 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL7 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL8 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HL9 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP1 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP2 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP3 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP4 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP5 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP6 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP7 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP8 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int HP9 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML1 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML2 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML3 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML4 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML5 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML6 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML7 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML8 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int ML9 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP1 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP2 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP3 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP4 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP5 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP6 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP7 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP8 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int MP9 { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Total { get; set; }

        [DefaultValue(0)]
        [Required]
        public int Deleted { get; set; }

        //FK
        [Required]
        public int KodeDTD { get; set; }
        public virtual RDTD RDTD { get; set; }


        //PK
        public ICollection<TRL> LstTRL { get; set; }

        public ICollection<RM01A> LstRM01A { get; set; }
        public ICollection<RM01ADiagnosis> LstRM01ADiagnosis { get; set; }

        public ICollection<RM03> LstRM03 { get; set; }

        public ICollection<RM03ICD10> LstRM03ICD10 { get; set; }

        public ICollection<RM23> LstRM23 { get; set; }
        public ICollection<RM23Diagnosis> LstRM23Diagnosis { get; set; }
        public ICollection<RM35Diagnosis> LstRM35Diagnosis { get; set; }
    }
}
