using AutoMapper;
using FurnaceCalculation.DAL.MSSQL.Entity;
using FurnaceСalculation.API.Entity;

namespace FurnaceСalculation.API
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Register, User>();
        }
    }
}
