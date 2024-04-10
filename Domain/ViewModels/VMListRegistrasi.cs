using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRegistrasi
    {
        public int Kode { get; set; }
        public int KodeRegistrasi {  get; set; }
        public int KodePasien { get; set; }
        public string NamaPasien { get; set; }
        public DateTime TglMasuk { get; set; }
        public DateTime TglKeluar { get; set; }
        public string Rawat { get; set; }
        public int? KodeRuang3 { get; set; }
        public string Ruang3 { get; set; }
        public int? KodeRawat { get; set; }
        public int KodeCaraBayar { get; set; }
        public string UCaraBayar3 { get; set; }
        public int DPJP { get; set; }
        public string NamaDPJP { get; set; }
        public int KodeRL { get; set; }
        public int KodeNipBayar { get; set; }
        public int KodeNipBayarUlang { get; set; }
        public string Ruang5 { get; set; }

        public int KodeIcd {  get; set; }
        public string UraianIcd {  get; set; }

        public int KodeIcd9 {  get; set; }
        public string UraianIcd9 {  get; set; }

        public int? KodeGrupBayar { get; set; }
        public int? IsConfirm {  get; set; }


    }
}
