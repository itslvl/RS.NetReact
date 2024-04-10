using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain{
    public class MyLogs
    {
        [Key]
        public int Kode { get; set; }
        public string UserId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        //{
        //    get
        //    {
        //        return timeStamp.HasValue? timeStamp.Value : DateTime.Now;
        //    }

        //    set { this.timeStamp = value; }
        //}

        //private DateTime? timeStamp = null;
    }
}
