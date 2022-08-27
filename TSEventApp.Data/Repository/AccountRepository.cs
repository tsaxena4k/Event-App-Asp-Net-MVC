using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;
using TSEventApp.Core.IRepository;

namespace TSEventApp.Infrastructure.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUser(SignUp userSignUp)
        {
            var user = new IdentityUser()
            {

                UserName = userSignUp.UserName,
                Email = userSignUp.Email
            };

            var result = await _userManager.CreateAsync(user, userSignUp.Password);
            return result;
        }

        public async Task<SignInResult> LoginUser(Login user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, true, false);
            return result;
        }

        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

        public string GetEmail(string organiser)
        {
            var result = _userManager.Users.FirstOrDefault(x => x.UserName == organiser).Email;
            return result;

        }

    }
}
