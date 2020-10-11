using AutoMapper;
using BOSSTips.Application.Models.RequestModels.QueryRequestModels.Boss;
using BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss;
using BOSSTips.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BOSSTips.Application.Handlers.QueryHandlers.Boss
{
    public class GetAllBossesQueryHandler : IRequestHandler<GetAllBossesRequestModel, IEnumerable<GetAllBossesResponseModel>>
    {
        private readonly IBossRepository bossRepository;
        private readonly IMapper mapper;

        public GetAllBossesQueryHandler(IBossRepository bossRepository, IMapper mapper)
        {
            this.bossRepository = bossRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GetAllBossesResponseModel>> Handle(GetAllBossesRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var bosses = await bossRepository.GetAll(request.Quantity);

                var bossesMaped = mapper.Map<IEnumerable<GetAllBossesResponseModel>>(bosses);

                return bossesMaped;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
