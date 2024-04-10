using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class ApplicationRole : IdentityRole

    {
        [DefaultValue("")]
        public string Deskripsi { get; set; }
        [DefaultValue(0)]
        public int Deleted { get; set; }
    }
}
