namespace DomainDto
{
    public class GolonganSeedDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Deleted { get; set; } = 0;
        public string Uraian { get; set; } = "";
        public string Uraian2 { get; set; } = "";

    }
}