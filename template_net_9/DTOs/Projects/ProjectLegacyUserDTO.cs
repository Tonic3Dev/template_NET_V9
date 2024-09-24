namespace template_net_9.DTOs.Projects
{
    public class ProjectLegacyUserDTO
    {
        public int Id { get; set; }
        public ProjectDTO Project { get; set; }
        public int UserId { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
    }
}
