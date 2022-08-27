using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TSEventApp.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "Please Provide a valid Password")]
        public string Password { get; set; }
    }
}
