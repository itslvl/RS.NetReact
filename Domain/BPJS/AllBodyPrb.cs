using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodyPrb
    {
        public BodyPrbInsert BodyPrbInsert { get; set; }
        public BodyPrbUpdate BodyPrbUpdate { get; set; }
        public BodyPrbDelete BodyPrbDelete { get; set; }
    }


    public class BodyPrbInsert
    {
        [Required] public string NoSep { get; set; } = "";
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string Alamat { get; set; } = "";
        [Required] public string Email { get; set; } = "";
        [Required] public string ProgramPRB { get; set; } = "";
        [Required] public string KodeDPJP { get; set; } = "";
        [Required] public string Keterangan { get; set; } = "";
        [Required] public string Saran { get; set; } = "";
        [Required] public string User { get; set; } = "";
        public List<Obat> Obat { get; set; }
    }


    public class BodyPrbUpdate
    {
        [Required] public string NoSrb { get; set; } = "";
        [Required] public string NoSep { get; set; } = "";
        [Required] public string Alamat { get; set; } = "";
        [Required] public string Email { get; set; } = "";
        [Required] public string KodeDPJP { get; set; } = "";
        [Required] public string Keterangan { get; set; } = "";
        [Required] public string Saran { get; set; } = "";
        [Required] public string User { get; set; } = "";
        public List<Obat> Obat { get; set; }
    }


    public class BodyPrbDelete
    {
        [Required] public string NoSrb { get; set; } = "";
        [Required] public string NoSep { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class Obat
    {
        [Required] public string KdObat { get; set; } = "";
        [Required] public string Signa1 { get; set; } = "";
        [Required] public string Signa2 { get; set; } = "";
        [Required] public string JmlObat { get; set; } = "";
    }


    public class Obat2
    {
        [Required] public string KdObat { get; set; } = "";
        [Required] public string NamaObat { get; set; } = ""; 
        [Required] public string Signa1 { get; set; } = "";
        [Required] public string Signa2 { get; set; } = "";
        [Required] public string JmlObat { get; set; } = "";
    }
}
