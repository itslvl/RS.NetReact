using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class SSResume
    {
        [Key]
        public int Kode { get; set; }        

        public string Nadi { get; set; } = string.Empty;
        public string SSCodeResumeNadi { get; set; } = string.Empty;
        
        public string Pernafasan { get; set; } = string.Empty;
        public string SSCodeResumePernafasan { get; set; } = string.Empty;

        public string Sistol { get; set; } = string.Empty;
        public string SSCodeResumeSistol { get; set; } = string.Empty;

        public string Diastole { get; set; } = string.Empty;
        public string SSCodeResumeDiastole { get; set; } = string.Empty;

        public string Suhu { get; set; } = string.Empty;
        public string SSCodeResumeSuhu { get; set; } = string.Empty;

        public DateTime Tanggal { get; set; } = DateTime.Now;



        //FK
        public int KodeRegistrasi { get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

    }
}
