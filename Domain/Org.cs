using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Org
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]public Guid Id { get; set; }
        public int Deleted { get; set; } = 0;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] public DateTime SaveDate { get; set; }
        public Guid SSOrganizationId { get; set; }
        public Guid SSClientID { get; set; }
        public Guid SSClientSecret { get; set; }
        public string OrgName { get; set; } = "";
        public OrgType OrgType { get; set; }

    }
}