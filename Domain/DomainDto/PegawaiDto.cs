namespace DomainDto
{
    public class PegawaiDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Deleted { get; set; } 
        public string NIP { get; set; }
        public string Nama { get; set; }
        public string TmpLahir { get; set; }

    }
}