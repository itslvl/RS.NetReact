using System.ComponentModel.DataAnnotations;
using System;

namespace DotNet.RS.Models.BPJS
{
    public class AllBodyAplicares
    {
        public BodyAplicaresInsert BodyAplicaresInsert { get; set; }
        public BodyAplicaresUpdate BodyAplicaresUpdate { get; set; }
        public BodyAplicaresDelete BodyAplicaresDelete { get; set; }
    }


    public class BodyAplicaresInsert
    {
        [Required] public string Kodekelas { get; set; } = "";
        [Required] public string Koderuang { get; set; } = "";
        [Required] public string Namaruang { get; set; } = "";
        [Required] public int Kapasitas { get; set; } = 0;
        [Required] public int Tersedia { get; set; } = 0;
        [Required] public int Tersediapria { get; set; } = 0;
        [Required] public int Tersediawanita { get; set; } = 0;
        [Required] public int Tersediapriawanita { get; set; } = 0;
    }


    public class BodyAplicaresUpdate
    {
        [Required] public string Kodekelas { get; set; } = "";
        [Required] public string Koderuang { get; set; } = "";
        [Required] public string Namaruang { get; set; } = "";
        [Required] public int Kapasitas { get; set; } = 0;
        [Required] public int Tersedia { get; set; } = 0;
        [Required] public int Tersediapria { get; set; } = 0;
        [Required] public int Tersediawanita { get; set; } = 0;
        [Required] public int Tersediapriawanita { get; set; } = 0;
    }


    public class BodyAplicaresDelete
    {
        [Required] public string Kodekelas { get; set; } = "";
        [Required] public string Koderuang { get; set; } = "";
    }


    



}
