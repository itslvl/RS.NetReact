using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListReturMutasi
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public int KodeRuang1 { get; set; }
        public string URuang1 { get; set; }
        public int KodeRuang2 { get; set; }
        public string URuang2 { get; set; }
        public int KodeRMutasi { get; set; }
        public string UMutasi { get; set; }
        public int Referensi { get; set; }
        public int KodeMutasi { get; set; }
        public string Catatan { get; set; }
        public int IsTerima { get; set; }
        public DateTime? TglTerima { get; set; }        
        public int NIPTerima { get; set; }
        public string UNIPTerima { get; set; }
        public int NIPRequest { get; set; }
        public string UNIPRequest { get; set; }        
    }
}
