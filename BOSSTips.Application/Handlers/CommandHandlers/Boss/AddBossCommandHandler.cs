using AutoMapper;
using BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss;
using BOSSTips.Application.Models.ResponseModels.CommandResponseModels.Boss;
using BOSSTips.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BOSSTips.Application.Handlers.CommandHandlers.Boss
{
    public class AddBossCommandHandler : IRequestHandler<AddBossRequestModel, AddBossResponseModel>
    {
        private readonly IBossRepository bossRepository;
        private readonly IMapper mapper;

        public AddBossCommandHandler(IBossRepository bossRepository, IMapper mapper)
        {
            this.bossRepository = bossRepository;
            this.mapper = mapper;
        }

        public async Task<AddBossResponseModel> Handle(AddBossRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var bossMapped = mapper.Map<Domain.Entities.Boss>(request);

                bossMapped.GenerateId();

                var id = await bossRepository.Add(bossMapped);

                var resultModel = new AddBossResponseModel
                {
                    Id = id
                };

                return resultModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
