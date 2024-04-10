using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListMutasi
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public int Referensi { get; set; }
        public string Catatan { get; set; }
        public int IsTerima { get; set; }
        public DateTime? TglTerima { get; set; }
        public int KodeRMutasi { get; set; }
        public string UMutasi { get; set; }
        public int KodeRuang3Dari { get; set; }
        public string URuang3Dari { get; set; }
        public int KodeRuang3Ke { get; set; }
        public string URuang3Ke { get; set; }
        public int NIPTerima { get; set; }
        public string NmTerima { get; set; }
        public int NIPRequest { get; set; }
        public string NmRequest { get; set; }
    }
}