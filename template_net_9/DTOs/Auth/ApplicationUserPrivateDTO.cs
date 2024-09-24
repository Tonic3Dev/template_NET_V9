namespace template_net_9.DTOs.Auth
{
    public class ApplicationUserPrivateDTO: ApplicationUserPublicDTO
    {
        public List<string> Roles { get; set; } = [];
    }
}
