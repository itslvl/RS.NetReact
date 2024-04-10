using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain{
    public class RM01ATindakan
    {
        [Key]
        public int Kode { get; set; }

        [MaxLength(1000)]
        [DefaultValue("")]
        [Required]
        public string Tindakan { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRM01A { get; set; }
        public virtual RM01A RM01A { get; set; }

        public int KodeICD9 { get; set; }
        public virtual RICD9 RICD9 { get; set; }

        public string SSCodeResumeICD9 { get; set; } = string.Empty;
    }
}
