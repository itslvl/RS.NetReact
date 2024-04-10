using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListDeposit
    {
        public int Kode { get; set; }
        public int Deleted { get; set; }
        public DateTime Tanggal { get; set; }
        public string Uraian { get; set; }
        public decimal Deposit { get; set; }





        //FK
        public int KodeRegistrasi { get; set; }
        public int KodePasien { get; set; }
        public string NamaPasien { get; set; }

        public int KodePegawaiKasir { get; set; }
        public string NamaPegawaiKasir { get; set; }

        public int KodePegawaiEdit { get; set; }
        public string NamaPegawaiEdit { get; set; }

        public int KodePegawaiHapus { get; set; }
        public string NamaPegawaiHapus { get; set; }
    }
}
