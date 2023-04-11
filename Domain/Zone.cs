namespace Domain
{
    public class Zone
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ProvinceId { get; set; } = 0;
        public int CityId { get; set; } = 0;
        public int DistrictId { get; set; } = 0;
        public int VillageId { get; set; } = 0;
        public string Definition { get; set; } = string.Empty;
        public ICollection<Location> Location { get; set; }
    }

    public class ZoneDto
    {
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int VillageId { get; set; }
        public string Definition { get; set; } = string.Empty;
    }
}