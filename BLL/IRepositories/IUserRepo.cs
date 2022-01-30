using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories
{
    public interface  IUserRepo:IBaseRepo<User>
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        Task<TokenVM> Refresh(TokenVM tokenVM);

    }
}
