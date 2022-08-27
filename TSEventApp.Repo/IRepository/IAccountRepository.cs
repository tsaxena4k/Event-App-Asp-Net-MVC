using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;

namespace TSEventApp.Core.IRepository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUp user);
        Task<SignInResult> LoginUser(Login user);
        Task SignOut();
        string GetEmail(string organiser);
    }
}
