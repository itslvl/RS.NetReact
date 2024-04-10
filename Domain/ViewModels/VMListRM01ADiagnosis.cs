namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM01ADiagnosis
    {
        public int Kode { get; set; }

        public string Diagnosis { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRM23 { get; set; }

        public int KodeICD10 { get; set; }
        public string UraianICD10 { get; set; }
    }
}
