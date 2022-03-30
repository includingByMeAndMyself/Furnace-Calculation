using AutoMapper;
using FurnaceCalculation.Domain.Entity;
using FurnaceСalculation.API.Entity;

namespace FurnaceСalculation.API
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Register, IUser>();
        }
    }
}
