using System.ComponentModel.DataAnnotations;

namespace CRM_APP.Auth
{
    public class EditRoleModel
    {

        public String Id { get; set; }
        [Required(ErrorMessage = "Role Name is required")]
        public String RoleName { get; set; }
        public List<String> Users { get; set; } = new List<string>(); //ArgumentNullException: Value cannot be null. (Parameter 'source') hatasını önler
    }
}
