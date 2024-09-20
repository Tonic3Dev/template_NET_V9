using AutoMapper;
using template_net_9.DTOs;
using template_net_9.Entities;

namespace template_net_9.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<ApplicationUser, LoginDTO>();
            CreateMap<ApplicationUser, ApplicationUserDTO>();
            CreateMap<ApplicationUserCreationDTO, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserPatchDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCreationDTO, Product>();
            CreateMap<Product, ProductPatchDTO>().ReverseMap();
        }
    }
}
