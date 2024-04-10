using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM36
    {
        public int Kode { get; set; }

        public string Diagnosis { get; set; }

        public string TeknikAnastesi { get; set; }

        public DateTime TglOperasi { get; set; }

        public int ListrikDiatermi { get; set; }

        public int ListrikSuction { get; set; }

        public int ListrikHeater { get; set; }

        public int ListrikGergaji { get; set; }

        public int ListrikLightSource { get; set; }

        public int ListrikExtension { get; set; }

        public int ListrikMejaOperasi { get; set; }

        public int ListrikFilmViewer { get; set; }

        public int ListrikMikroskop { get; set; }

        public int ListrikWSD { get; set; }

        public int ListrikLampuOperasi { get; set; }

        public int ListrikLampuKamar { get; set; }

        public int ListrikAC { get; set; }

        public int AlatTabung { get; set; }

        public int AlatPatient { get; set; }

        public int AlatInstrumen { get; set; }

        public int AlatHandle { get; set; }

        public int AlatKom { get; set; }

        public int LinenJas { get; set; }

        public int LinenDuk { get; set; }

        public int LinenSarungMeja { get; set; }

        public int LinenSarungKhaki { get; set; }

        public int LinenSarungSuction { get; set; }

        public int AKHP { get; set; }

        public int Deleted { get; set; }


        //FK
        public int KodeRegistrasi { get; set; }

        public int KodeRuang3 { get; set; }
        public string UraianRuang3 { get; set; }

        public int KodeTindakanRM { get; set; }
        public string UraianTindakanRM { get; set; }

        public int KodeNipPerawat { get; set; }
        public string NamaPerawat { get; set; }

        public int KodeNipKepalaRuangan { get; set; }
        public string NamaKepalaRuangan { get; set; }


    }
}
