using Microsoft.AspNetCore.Identity;

namespace template_net_9.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public UserTypeEnum UserType { get; set; }
        public bool Active { get; set; } = true;
    }

    public enum UserTypeEnum
    {
        Admin, // 0
        User  // 1
    }

}
