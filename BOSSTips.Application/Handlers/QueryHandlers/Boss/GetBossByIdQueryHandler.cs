using AutoMapper;
using BOSSTips.Application.Models.RequestModels.QueryRequestModels.Boss;
using BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss;
using BOSSTips.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BOSSTips.Application.Handlers.QueryHandlers.Boss
{
    public class GetBossByIdQueryHandler : IRequestHandler<GetBossByIdRequestModel, GetBossByIdResponseModel>
    {
        private readonly IBossRepository bossRepository;
        private readonly IMapper mapper;

        public GetBossByIdQueryHandler(IBossRepository bossRepository, IMapper mapper)
        {
            this.bossRepository = bossRepository;
            this.mapper = mapper;
        }

        public async Task<GetBossByIdResponseModel> Handle(GetBossByIdRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var boss = await bossRepository.GetById(request.Id);

                var bossMapped = mapper.Map<GetBossByIdResponseModel>(boss);

                return bossMapped;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
