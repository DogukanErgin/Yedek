using CRM_APP.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CRM_APP.Auth
{
    public class RegisterModel  //create User
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Authenticate")]
        [ValidEmailDomainAttribute(allowedDomain: "hotmail.com", ErrorMessage = "Email domain must be hotmail.com")]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password dont match")]
        public string? ConfirmPassword { get; set; }


    }
}
