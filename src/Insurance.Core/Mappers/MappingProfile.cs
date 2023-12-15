using AutoMapper;
using Insurance.Core.Models;
using Insurance.Infrastructure.Entities;

namespace Insurance.Core.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
