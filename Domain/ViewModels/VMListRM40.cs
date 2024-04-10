using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM40
    {
        public int Kode { get; set; }


        public DateTime Tanggal { get; set; }

        public int AnastesiUmum { get; set; }

        public int AnastesiSpinal { get; set; }

        public int AnastesiEpidural { get; set; }

        public int AnastesiBSP { get; set; }

        public int AnastesiCSP { get; set; }

        public int AnastesiLokal { get; set; }

        public int SifatEmergensi { get; set; }

        public int SifatEfektif { get; set; }

        public int GolonganMinor { get; set; }

        public int GolonganMedium { get; set; }

        public int GolonganMayor { get; set; }

        public int GolonganKhusus { get; set; }

        public string DiagnosisPraBedah { get; set; }

        public string DiagnosisPascaBedah { get; set; }

        public string IndikasiOperasi { get; set; }

        public string TindakanOperasi { get; set; }

        public string JaringanEksisi { get; set; }

        public int PaY { get; set; }

        public int PaT { get; set; }

        public DateTime TglMulai { get; set; }

        public DateTime TglSelesai { get; set; }

        public string Durasi { get; set; }

        public string Komplikasi { get; set; }

        public string JumlahPendarahan { get; set; }

        public int PascaRuangan { get; set; }

        public int PascaPicu { get; set; }

        public int PascaHCU { get; set; }

        public int PascaRR { get; set; }

        public int PascaICU { get; set; }

        public string PosisiPasien { get; set; }

        public string Dalam { get; set; }

        public string Anastesi { get; set; }

        public string Aseptik { get; set; }

        public string Droping { get; set; }

        public string Insisi { get; set; }

        public string Implan { get; set; }

        public string NoRegister { get; set; }

        public string Instruksi { get; set; }

        public DateTime TglSelesaiLaporan { get; set; }

        public int Deleted { get; set; }




        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeNipDokterOperator { get; set; }
        public string NamaDokterOperator { get; set; }

        public int KodeNipDokterAnastesi { get; set; }
        public string NamaDokterAnastesi { get; set; }

        public int KodeNipAsistenOperator { get; set; }
        public string NamaAsistenOperator { get; set; }

        public int KodeNipPerawatAnastesi { get; set; }
        public string NamaPerawatAnastesi { get; set; }

    }
}
