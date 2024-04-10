using System;

namespace DotNet.RS.Models.ViewModels
{
    public class TRegistrasiCaption
    {
        public int KodePasien { get; set; }
        public DateTime TglMasuk { get; set; }
        public string NamaPasien { get; set; }
        public string UDPJP { get; set; }
        public string UPengirim { get; set; }
        public string UCaraBayar3 { get; set; }
        public bool IsRujuk { get; set; }
        public bool IsAwal { get; set; }
    }
}
