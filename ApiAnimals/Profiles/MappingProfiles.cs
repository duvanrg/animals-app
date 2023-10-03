using ApiAnimals.Dtos;
using AutoMapper;
using Core.Entities;

namespace ApiAnimals.Profiles
{
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            CreateMap<Pais, PaisDto>().ReverseMap();
        }

    }
}