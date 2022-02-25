using System.ComponentModel.DataAnnotations;

namespace CRM_APP.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }



        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
