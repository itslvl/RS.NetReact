using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain{
    public class RM01ADiagnosis
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Diagnosis { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRM01A { get; set; }
        public virtual RM01A RM01A { get; set; }

        public int KodeICD10 { get; set; }
        public virtual RICD RICD10 { get; set; }

        public string SSCodeResumeICD10 { get; set; } = string.Empty;
    }
}
