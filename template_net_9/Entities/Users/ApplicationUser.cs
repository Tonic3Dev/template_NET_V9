using Microsoft.AspNetCore.Identity;

namespace template_net_9.Entities.Users
{
    public class ApplicationUser : IdentityUser
    {
        public int LegacyUserId { get; set; }
        public LegacyUser LegacyUser { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
    }
}
