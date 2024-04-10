using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListTutupStok
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public decimal Awal { get; set; }
        public decimal Akhir { get; set; }
        public DateTime Tanggal { get; set; }
        public int IsGabung { get; set; }
        public int IsTutup { get; set; }

        public int KodeLogistikGudang { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
        public int NIP { get; set; }
        public string UPegawai { get; set; }
    }
}
