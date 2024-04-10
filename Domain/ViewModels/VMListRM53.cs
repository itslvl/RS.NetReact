using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM53
    {
        public int Kode { get; set; }

        public DateTime Tanggal { get; set; }

        public string Diagnosis { get; set; }

        public string DasarDiagnosis { get; set; }

        public string Terapi { get; set; }

        public string Prognosis { get; set; }

        public string PenerimaInformasi { get; set; }

        public int Deleted { get; set; }

        public int KodeRegistrasi { get; set; }

        public int KodeNipPemberiInformasi { get; set; }
        public string NamaPemberiInformasi { get; set; }
    }
}
