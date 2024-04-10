using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class DtUserRoles
    {
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string NIP { get; set; }
        public string Nama { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [DefaultValue(0)]
        public int IsPegawai { get; set; }
        [DefaultValue(0)]
        public int Deleted { get; set; }
        public IEnumerable<VMRoles> RoleData { get; set; }
    }

    public class VMUserRole
    {
        public string Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string NIP { get; set; }
        public string Nama { get; set; }
        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }
        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
        //[DefaultValue(0)]
        public int IsPegawai { get; set; }
        [DefaultValue(0)]
        public int Deleted { get; set; }
        public List<VMRoles> Data { get; set; }

    }
    public class VMRoles
    {
        public bool Checked { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdUser { get; set; }
    }
}
