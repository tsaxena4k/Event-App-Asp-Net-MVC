using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TSEventApp.Application.Models;

namespace TSEventApp.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignUpModel signUp);
        Task<SignInResult> LoginUser(LoginModel loginModel);

        Task SignOut();
        string GetEmail(string organiser);
    }
}
