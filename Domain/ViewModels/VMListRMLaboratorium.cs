using System;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRMLaboratorium
    {
        public int KodeRegistrasi { get; set;}
        public int KodeRRuang5 { get; set; }
        public string UraianRRuang3 { get; set; }
        public int KodeTTindakan1 { get; set; }
        public DateTime Tanggal { get; set; }
        public int KodeTTindakan2 { get; set; }
        public int KodeRTindakan3 { get; set; }
        public string UraianTindakan3 { get; set; }
        public string NamaDokter { get; set; }

        public int KodeRincianLab { get; set; }
        public string UraianRincianLab { get; set; }
        public string SatuanRincianLab { get; set; }
        public string RujukanRincianLab { get; set; }
        public string HasilRincianLab { get; set; }


        public string KeteranganRadiologi { get; set; }
        public string KesimpulanRadiologi { get; set; }




    }
}
