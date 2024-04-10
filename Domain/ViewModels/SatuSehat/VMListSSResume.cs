using System;

namespace DotNet.RS.Models.ViewModels.SatuSehat
{
    public class VMListSSResume
    {
        public int Kode { get; set; }
        public int Parameter { get; set; }
        public DateTime Tanggal { get; set; }
        public string Keterangan { get; set; }
        public int KodeRegistrasi { get; set; }
        public string ValueSend { get; set; }
        public string SSCode { get; set; }
        public string UrlCreate { get; set; }
        public string UrlById { get; set; }
        
    }
}
