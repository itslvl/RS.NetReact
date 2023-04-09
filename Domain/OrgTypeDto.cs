namespace Domain
{
    public class OrgTypeDto
    {
        public string Code { get; set; } 
        public string Display { get; set; } 
        public string Definition { get; set; } 
        public ICollection<Org> Org { get; set; } 

    }
}