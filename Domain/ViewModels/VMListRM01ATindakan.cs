namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM01ATindakan
    {
        public int Kode { get; set; }

        public string Tindakan { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRM01A { get; set; }

        public int KodeICD9 { get; set; }
        public string UraianICD9 { get; set; }
    }
}
