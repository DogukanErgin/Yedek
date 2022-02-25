using System.ComponentModel.DataAnnotations;

namespace CRM_APP.Auth
{
    public class CreateRoleModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
