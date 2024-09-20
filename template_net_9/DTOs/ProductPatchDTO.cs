﻿using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs
{
    public class ProductPatchDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }
    }
}
