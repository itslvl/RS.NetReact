using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMInputUserRole
    {
        public ApplicationUser User { get; set; }
        public List<VMInputRole> Role  { get; set; }

    }
}
