using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DefaultValue("")]
        public string NIP { get; set; }
        [Required]
        [DefaultValue("")]
        public string Nama { get; set; }
        [Required]
        [DefaultValue(0)]
        public int IsPegawai { get; set; }
        [Required]
        [DefaultValue(0)]
        public int Deleted { get; set; }
      

    }
}
