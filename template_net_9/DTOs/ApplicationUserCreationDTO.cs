﻿using template_net_9.Entities;

namespace template_net_9.DTOs
{
    public class ApplicationUserCreationDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName => Email;
        public string Password { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
