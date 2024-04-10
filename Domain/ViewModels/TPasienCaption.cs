using System;

namespace DotNet.RS.Models.ViewModels
{
    public class TPasienCaption
    {
        public int KodePasien { get; set; }
        public string NamaPasien { get; set; }
        public DateTime TglLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string NIK { get; set; }
        public string NoKaBpjs { get; set; }
        public string Alamat { get; set; }
    }
}
