using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMKonsinyasi2
    {
        public TKonsinyasi TKonsinyasi { get; set; }
        public TKonsinyasiDt TKonsinyasiDt { get; set; }
        public List<TKonsinyasiDt> ListTKonsinyasiDt { get; set; }
    }
}
