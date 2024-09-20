using template_net_9.Entities;

namespace template_net_9.DTOs
{
    public class ApplicationUserDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
