using AutoMapper;
using Magic_Villa.Models;
using Magic_Villa.Models.DTO;

namespace Magic_Villa
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<VillaDTO, Villa>().ReverseMap();

            CreateMap<Villa, VillasCreateDTO>().ReverseMap();
            CreateMap<Villa, VillasUpdateDTO>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}