using AspNetCoreHero.ToastNotification.Abstractions;
using System;

namespace DotNet.RS.Models
{
    public class TRL2
    {
        public Guid id { get; set; } = new Guid();
        public int Tahun { get; set; }
        public int KodeRPendidikan1 { get; set; }
        public int KodeRPendidikan2 { get; set; }
        public int KodeRPendidikan3 { get; set; }
        public string UraianRPendidikan1 { get; set; }
        public string UraianRPendidikan2 { get; set; }
        public string UraianRPendidikan3 { get; set; }
        public string UrutReporting { get; set; }
        public int KeadaanL { get; set; }
        public int KeadaanP { get; set; }
        public int KebutuhanL { get; set; }
        public int KebutuhanP { get; set; }
        public int KekuranganL { get; set; }
        public int KekuranganP { get; set; }

    }
}
