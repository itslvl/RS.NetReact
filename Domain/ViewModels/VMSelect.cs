using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMSelect
    {
        public int Kode { get; set; }
        public string Uraian { get; set; }
    }

    public class VMSelectInt
    {
        public int FieldValue { get; set; }
    }
    
    public class VMSelectDecimal
    {
        public decimal FieldValue { get; set; }
    }

    public class VMSelectString
    {
        public string FieldValue { get; set; }
    }
}