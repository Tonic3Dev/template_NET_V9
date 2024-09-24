using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Permissions
{
    public class GroupLegacyUserCreationDTO
    {

        [Required]
        public int GroupId { get; set; }

        [Required]
        public int LegacyUserId { get; set; }
    }
}
