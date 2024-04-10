using System.ComponentModel.DataAnnotations;

namespace Domain{
    public class SSTRegistrasi
    {
        [Key]
        public int Kode { get; set; }
        public int KodeTRegistrasi { get; set; }
        public string SSCode { get; set; }
    }
}
