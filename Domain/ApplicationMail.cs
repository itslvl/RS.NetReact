using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models
{
    public class ApplicationMail
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string FromEmail { get; set; }
        public string FromPassword { get; set; }
    }
}
