using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.R
{
    public class ROrgType
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime SaveDate { get; set; } = DateTime.UtcNow;
        public string Code { get; set; } = "";
        public string Display { get; set; } = "";
        public string Definition { get; set; } = "";
    }
}