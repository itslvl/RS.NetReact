using System;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM22
    {
        public int Kode { get; set; }
        public int KodeRegistrasi { get; set; }
        public DateTime Tanggal { get; set; }
        public string UraianRuangan { get; set; }
        public string NamaDokter { get; set; }

        public string UraianLogistik { get; set; }
        public string UraianCaraPakai { get; set; }
        public string UraianDosis { get; set; }
        public string Indikasi { get; set; }
        public string WaktuMinum { get; set; }
    }
}
