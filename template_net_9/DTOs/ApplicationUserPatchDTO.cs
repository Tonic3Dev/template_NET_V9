using template_net_9.Entities;

namespace template_net_9.DTOs
{
    public class ApplicationUserPatchDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
