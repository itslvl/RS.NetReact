using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.R
{
    public class ROrg
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]public Guid Id { get; set; }
        public int Deleted { get; set; } = 0;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] public DateTime SaveDate { get; set; }
        public Guid SSOrganizationId { get; set; }
        public Guid SSClientID { get; set; }
        public Guid SSClientSecret { get; set; }
        public string OrgName { get; set; } = "";
        public ROrgType OrgType { get; set; }

    }
}