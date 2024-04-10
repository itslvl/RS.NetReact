using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMReturPembelian2
    {
        public TReturPembelian TReturPembelian { get; set; }
        public List<TReturPembelianDt> ListTReturPembelianDt { get; set; }
        public TReturPembelianDt TReturPembelianDt { get; set; }
    }
}
