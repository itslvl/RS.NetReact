namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM23Obat
    {
        public int Kode { get; set; }

        public decimal Jumlah { get; set; }
        public string Manifestasi { get; set; }
        public string Keterangan { get; set; }
        public string Frekuensi { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRM23 { get; set; }

        public int KodeLogistik { get; set; }
        public string UraianLogistik { get; set; }
        public string UraianSatuan { get; set; }

        public int KodeCaraPakai { get; set; }
        public string UraianCaraPakai { get; set; }

        public int KodeDosis { get; set; }
        public string UraianDosis { get; set; }



    }
}
