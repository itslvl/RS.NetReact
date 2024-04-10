using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class TRL4
    {
        public Guid id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int Tahun { get; set; }
        public int Bulan { get; set; }
        public int KodeDtd { get; set; }

        [DefaultValue(0)]
        public int Sub { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string NomorDtd { get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [Required]
        public string UraianDtd { get; set; }

        [MaxLength(6000)]
        [DefaultValue("")]
        [Required]
        public string KodeIcd { get; set; }

        [DefaultValue(0)]
        public int HL1 { get; set; }

        [DefaultValue(0)]
        public int HL2 { get; set;}

        [DefaultValue(0)]
        public int HL3 { get; set;}

        [DefaultValue(0)]
        public int HL4 { get; set;}

        [DefaultValue(0)]
        public int HL5 { get; set;}

        [DefaultValue(0)]
        public int HL6 { get; set;}

        [DefaultValue(0)]
        public int HL7 { get; set;}

        [DefaultValue(0)]
        public int HL8 { get; set;}

        [DefaultValue(0)]
        public int HL9 { get; set;}

        [DefaultValue(0)]
        public int HP1 { get; set;}

        [DefaultValue(0)]
        public int HP2 { get; set;}

        [DefaultValue(0)]
        public int HP3 { get; set;}

        [DefaultValue(0)]
        public int HP4 { get; set;}

        [DefaultValue(0)]
        public int HP5 { get; set;}

        [DefaultValue(0)]
        public int HP6 { get; set;}

        [DefaultValue(0)]
        public int HP7 { get; set;}

        [DefaultValue(0)]
        public int HP8 { get; set;}

        [DefaultValue(0)]
        public int HP9 { get; set;}

        [DefaultValue(0)]
        public int ML1 { get; set;}

        [DefaultValue(0)]
        public int ML2 { get; set;}

        [DefaultValue(0)]
        public int ML3 { get; set;}

        [DefaultValue(0)]
        public int ML4 { get; set;}

        [DefaultValue(0)]
        public int ML5 { get; set;}

        [DefaultValue(0)]
        public int ML6 { get; set;}

        [DefaultValue(0)]
        public int ML7 { get; set;}

        [DefaultValue(0)]
        public int ML8 { get; set;}

        [DefaultValue(0)]
        public int ML9 { get; set;}

        [DefaultValue(0)]
        public int MP1 { get; set;}

        [DefaultValue(0)]
        public int MP2 { get; set;}

        [DefaultValue(0)]
        public int MP3 { get; set;}

        [DefaultValue(0)]
        public int MP4 { get; set;}

        [DefaultValue(0)]
        public int MP5 { get; set;}

        [DefaultValue(0)]
        public int MP6 { get; set;}

        [DefaultValue(0)]
        public int MP7 { get; set;}

        [DefaultValue(0)]
        public int MP8 { get; set;}

        [DefaultValue(0)]
        public int MP9 { get; set;}

        [DefaultValue(0)]
        public int L1 { get; set; }

        [DefaultValue(0)]
        public int L2 { get; set; }

        [DefaultValue(0)]
        public int L3 { get; set; }

        [DefaultValue(0)]
        public int L4 { get; set; }

        [DefaultValue(0)]
        public int L5 { get; set; }

        [DefaultValue(0)]
        public int L6 { get; set; }

        [DefaultValue(0)]
        public int L7 { get; set; }

        [DefaultValue(0)]
        public int L8 { get; set; }

        [DefaultValue(0)]
        public int L9 { get; set; }

        [DefaultValue(0)]
        public int P1 { get; set; }

        [DefaultValue(0)]
        public int P2 { get; set; }

        [DefaultValue(0)]
        public int P3 { get; set; }

        [DefaultValue(0)]
        public int P4 { get; set; }

        [DefaultValue(0)]
        public int P5 { get; set; }

        [DefaultValue(0)]
        public int P6 { get; set; }

        [DefaultValue(0)]
        public int P7 { get; set; }

        [DefaultValue(0)]
        public int P8 { get; set; }

        [DefaultValue(0)]
        public int P9 { get; set; }

        [DefaultValue(0)]
        public int JumlahL { get; set; }

        [DefaultValue(0)]
        public int JumlahP { get; set; }

        [DefaultValue(0)]
        public int JumlahHidup { get; set; }

        [DefaultValue(0)]
        public int JumlahExit { get; set; }
    }
}
