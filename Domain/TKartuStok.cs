using System;

namespace DotNet.RS.Models
{
    public class TKartuStok
    {
        public Guid Id { get; set; } = new Guid();
        public int KodeNip { get; set; }
        public int KodeRuang3 { get; set; }
        public int KodeRuang3Tujuan { get; set; }
        public string UraianRuang3Tujuan { get; set; }
        public int KodeLogistik { get; set; }
        public string UraianLogistik { get; set; }
        public int KodeMutasi { get; set; }
        public int KodeRegistrasi { get; set; }
        public int KodePasien { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Mutasi { get; set; }
        public int IsMinus { get; set; }
        public string Uraian { get; set; }
        public string Uraian2 { get; set; }
        public decimal RealMutasi { get; set; }
        public string Alamat { get; set; }




    }
}
