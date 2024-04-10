using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMTindakan1234
    {
        public int Kode { get; set; }
        public string Uraian { get; set; }
        public string Uraian1 { get; set; }
        public string Uraian2 { get; set; }
        public string Uraian3 { get; set; }
        public string Uraian4 { get; set; }
        

        public decimal Harga { get; set; }
        public decimal Dokter { get; set; }
        public int IsDokter { get; set; }


        public string UraianAkunInap { get; set; }
        public string UraianAkunJalan { get; set; }
        public int RBayar2KodeAkunInap { get; set; }
        public int RBayar2KodeAkunJalan { get; set; }


        public string UInaCBG52 { get; set; }
        public int RInaCBG52Kode { get; set; }

        public int KodeRTindakan1 { get; set; }
        public int KodeRTindakan2 { get; set; }
        public int KodeRTindakan3 { get; set; }
        public int KodeRTindakan4 { get; set; }
        public int Deleted { get; set; }
        
        public string Satuan { get; set; }
        public string Rujukan { get; set; }
        public string Metode { get; set; }
        public int Grup { get; set; }
    }
}
