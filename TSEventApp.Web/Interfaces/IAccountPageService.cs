using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TSEventApp.Web.Models;

namespace TSEventApp.Web.Interfaces
{
    public interface IAccountPageService
    {
        Task<IdentityResult> CreateUser(SignUpViewModel signUpViewModel);

        Task<SignInResult> LoginUser(LoginViewModel loginViewModel);

        Task SignOut();
        string GetEmail(string organiser);
    }
}
