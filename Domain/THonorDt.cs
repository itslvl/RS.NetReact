using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DotNet.RS.Models
{
    public class THonorDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TglTrans { get; set; }

        [DefaultValue(0.00)]
        public decimal Qty {  get; set; }

        [DefaultValue(0.00)]
        public decimal Total {  get; set; }

        [MaxLength(255)]
        [DefaultValue("")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Keterangan {  get; set; }




        //FK
        public int KodeHonor {  get; set; }
        public virtual THonor THonor { get; set; }

        public int KodeRTindakan3 { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set;}
    }
}
