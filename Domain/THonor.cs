using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models
{
    public class THonor
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Tanggal { get; set; }

        [DefaultValue(0.00)]
        public decimal Total {  get; set; }

        [DefaultValue(0)]
        public int IsConfirm {  get; set; }


        //FK
        public int KodeRegistrasi {  get; set; }
        public virtual TRegistrasi TRegistrasi { get; set; }

        public int KodeNip {  get; set; }
        public virtual TPegawai TPegawai { get; set; }


        //PK
        public ICollection<THonorDt> LstTHonorDt { get; set; }
    }
}
