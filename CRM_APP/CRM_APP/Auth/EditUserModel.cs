using CRM_APP.Models.entities;
using System.ComponentModel.DataAnnotations;

namespace CRM_APP.Auth
{
    public class EditUserModel :BaseEntityId
    {
      //  public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> Claims { get; set; } = new List<string>();
        public IList<string> Roles { get; set; } = new List<string>();

    }
}
