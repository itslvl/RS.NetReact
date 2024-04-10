using System;
using System.Security;
using System.Threading.Tasks;

namespace Domain{
    public class APIResult
    {
        public string Code { get; set; } = "";
        public string Message { get; set; } = "";
        public string Body { get; set; } = "";
        public string Response { get; set; } = "";

        public static explicit operator APIResult(Task<APIResult> v)
        {
            throw new NotImplementedException();
        }
    }
}
