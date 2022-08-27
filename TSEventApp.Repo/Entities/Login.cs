using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TSEventApp.Core.Entities
{
    public class Login
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
