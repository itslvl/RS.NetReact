using System;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM06
    {
        public int Kode { get; set; }
        public int KodeRegistrasi { get; set; }
        public DateTime Tanggal { get; set; }
        public string UraianRuangan { get; set; }
        public string NamaDokterJaga { get; set; }
        public string PdfUrl { get; set; }
    }
}
