using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.R.Temp
{
    public class ROrg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Deleted { get; set; } = 0;
        public Guid SSOrganizationId { get; set; }
        public Guid SSClientID { get; set; }
        public Guid SSClientSecret { get; set; }
        public string OrgName { get; set; } = "";
        public ROrgType OrgType { get; set; }
    }
    public class ROrgType
    {
       
    }
    public class RTerritory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required] public int CodeProv { get; set; }
        [Required] public int CodeKabKota { get; set; }
        [Required] public int CodeKec { get; set; }
        [Required] public int CodeDesa { get; set; }
        [Required] public string Display { get; set; } = "";
        [Required] public string Description { get; set; } = "";
    }
}