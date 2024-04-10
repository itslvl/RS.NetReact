using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMExpired2
    {
        public TLogistikExpired TLogistikExpired { get; set; }
        public TLogistikExpiredDt TLogistikExpiredDt { get; set; }
        public List<TLogistikExpiredDt> ListTLogistikExpiredDt { get; set; }
    }
}
