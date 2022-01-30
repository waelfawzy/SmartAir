using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class TokenVM
    {
        public string AccessToken { set; get; }
        public string RefreshToken { set; get; }
        public string? SecretKey { set; get; }
    }

}
