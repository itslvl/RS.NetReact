using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class APIModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string value { get; set; }
        public string Description { get; set; }
    }
}
