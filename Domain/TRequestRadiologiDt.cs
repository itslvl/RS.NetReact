using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain{
    public class TRequestRadiologiDt
    {
        [Key]
        public int Kode { get; set; }

        [DefaultValue(0)]
        public int Deleted { get; set; }



        //FK
        public int KodeRequestRadiologi { get; set; }
        public virtual TRequestRadiologi TRequestRadiologi { get; set; }

        public int KodeTindakan { get; set; }
        public virtual RTindakan3 RTindakan3 { get; set; }
    }
}
