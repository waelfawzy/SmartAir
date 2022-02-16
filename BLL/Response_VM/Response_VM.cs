using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Response_VM
{
    public class Response_VM
    {
        public object Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
