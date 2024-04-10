using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListReturResep
    {
        public int Kode { get; set; }
        public DateTime Tanggal { get; set; }
        public string NamaPasien { get; set; }
        public string NamaDokter { get; set; }
        public string Catatan { get; set; }
    }
}
