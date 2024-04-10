using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class SatuSehat
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime AksesDateTime { get; set; }
        [Required] public string AksesName { get; set; }
        [Required] public string AksesResult { get; set; }
        [DefaultValue("")] public string AksesBody { get; set; }
        [DefaultValue("")] public string Value { get; set; }
    }
}
