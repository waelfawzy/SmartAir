using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class AuthenticateResponse
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Token { set; get; }
        public string RefreshToken { set; get; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Token = token;
            RefreshToken = user.RefreshToken;
        }
    }
}
