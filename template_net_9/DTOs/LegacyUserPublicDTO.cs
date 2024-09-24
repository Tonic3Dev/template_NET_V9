using template_net_9.DTOs.BusinessUnit;

namespace template_net_9.DTOs
{
    public class LegacyUserPublicDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public BusinessUnitDTO BusinessUnit { get; set; }
        public int FileNumber { get; set; }
    }
}
