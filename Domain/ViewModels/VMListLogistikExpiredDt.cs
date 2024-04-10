using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListLogistikExpiredDt
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime TglExpired { get; set; }
        public decimal Jumlah { get; set; }
        public int IsTerima { get; set; }
        public int KodeLogistikExpired { get; set; }
        public int KodeLogistik { get; set; }
        public string ULogistik { get; set; }
    }
}
