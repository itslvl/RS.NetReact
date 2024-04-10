using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DotNet.RS.Models
{
    public class TRequestLabDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRequestLab { get; set; }
        public virtual TRequestLab TRequestLab { get; set; }

        public int KodeTindakan { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set; }



    }
}
