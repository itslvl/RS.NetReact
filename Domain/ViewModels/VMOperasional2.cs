using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMOperasional2
    {
        public TLogistikOperasional TLogistikOperasional { get; set; }
        public TLogistikOperasionalDt TLogistikOperasionalDt { get; set; }
        public List<TLogistikOperasionalDt> ListTLogistikOperasionalDt { get; set; }
    }
}
