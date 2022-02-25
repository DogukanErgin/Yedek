using Microsoft.AspNetCore.Identity;

namespace CRM_APP.Models.entities
{
    public class WorkPlan :BaseEntityId
    {
        public List<Company> Companies { get; set; }

        public List<IdentityUser> Participants { get; set; }

        public String Description { get; set; }

        public String? Description2{ get; set; }

        public String? Description3 { get; set; }

    }
}
