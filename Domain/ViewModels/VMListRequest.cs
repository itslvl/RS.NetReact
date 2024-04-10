using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRequest
    {
        public int Kode { get; set; }
        public int KodePasien { get; set; }
        public string NamaPasien { get; set; }
        public DateTime Tanggal { get; set; }
        public string Rawat { get; set; }
        public int? KodeRuang3 { get; set; }
        public string Ruang3 { get; set; }
        public int? KodeRawat { get; set; }
        public int KodeRegistrasi { get; set; }
        public int KodeDokterRequest { get; set; }
        public string NamaDokterRequest { get; set; }
        public int KodePerawatRequest { get; set; }
        public string NamaPerawatRequest { get; set; }
        public int KodeRuang3Request { get; set; }
        public string UraianRuang3Request { get; set; }
        public int KodeRuang3Tujuan { get; set; }
        public string UraianRuang3Tujuan { get; set; }
        public string Catatan { get; set; }
        public int IsNotif { get; set; }





    }
}
