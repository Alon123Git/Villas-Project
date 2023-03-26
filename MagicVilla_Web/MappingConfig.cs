using AutoMapper;
using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaDTO, VillasCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillasUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillasCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillasUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}