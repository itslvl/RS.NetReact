using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodyRujukan
    {
        public BodyRujukanInsert BodyRujukanInsert { get; set; }
        public BodyRujukanUpdate BodyRujukanUpdate { get; set; }
        public BodyRujukanDelete BodyRujukanDelete { get; set; }
        public BodyRujukanKhususInsert BodyRujukanKhususInsert { get; set; }
        public BodyRujukanKhususDelete BodyRujukanKhususDelete { get; set; }
    }


    public class BodyRujukanInsert
    {
        [Required] public string NoSep { get; set; } = "";
        [Required] public string TglRujukan { get; set; } = "";
        [Required] public string TglRencanaKunjungan { get; set; } = "";
        [Required] public string PpkDirujuk { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string Catatan { get; set; } = "";
        [Required] public string DiagRujukan { get; set; } = "";
        [Required] public string TipeRujukan { get; set; } = "";
        [Required] public string PoliRujukan { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodyRujukanUpdate
    {
        [Required] public string NoRujukan { get; set; } = "";
        [Required] public string TglRujukan { get; set; } = "";
        [Required] public string TglRencanaKunjungan { get; set; } = "";
        [Required] public string PpkDirujuk { get; set; } = "";
        [Required] public string JnsPelayanan { get; set; } = "";
        [Required] public string Catatan { get; set; } = "";
        [Required] public string DiagRujukan { get; set; } = "";
        [Required] public string TipeRujukan { get; set; } = "";
        [Required] public string PoliRujukan { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodyRujukanDelete
    {
        [Required] public string NoRujukan { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class BodyRujukanKhususInsert
    {
        [Required] public string NoRujukan { get; set; } = "";
        public List<Diagnosa> Diagnosa { get; set; }
        public List<Procedure> Procedure { get; set; }
        [Required] public string User { get; set; } = "";
    }


    public class BodyRujukanKhususDelete
    {
        [Required] public string IdRujukan { get; set; } = "";
        [Required] public string NoRujukan { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }


    public class Diagnosa
    {
        [Required] public string Kode { get; set; } = "";
    }


    public class Procedure
    {
        [Required] public string Kode { get; set; } = "";
    }


}
