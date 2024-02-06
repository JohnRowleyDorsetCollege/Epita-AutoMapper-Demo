using AutoMapper;
using System.Runtime.InteropServices;

namespace Epita_AutoMapper_Demo.Models
{
    public class AutoMapperProfile : Profile
    {
       public AutoMapperProfile()
        {
            CreateMap<Superhero, SuperheroDTO>();
        }
    }
}
