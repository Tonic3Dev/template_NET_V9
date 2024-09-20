using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
