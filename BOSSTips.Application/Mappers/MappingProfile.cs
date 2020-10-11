using AutoMapper;
using BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss;
using BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss;
using BOSSTips.Domain.Entities;

namespace BOSSTips.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Boss, GetAllBossesResponseModel>().ReverseMap();
            CreateMap<Boss, GetBossByIdResponseModel>().ReverseMap();

            CreateMap<Boss, AddBossRequestModel>().ReverseMap();
            CreateMap<Boss, UpdateBossRequestModel>().ReverseMap();
        }
    }
}
