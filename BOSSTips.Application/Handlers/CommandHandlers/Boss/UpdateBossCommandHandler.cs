using AutoMapper;
using BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss;
using BOSSTips.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BOSSTips.Application.Handlers.CommandHandlers.Boss
{
    public class UpdateBossCommandHandler : IRequestHandler<UpdateBossRequestModel>
    {
        private readonly IBossRepository bossRepository;
        private readonly IMapper mapper;

        public UpdateBossCommandHandler(IBossRepository bossRepository, IMapper mapper)
        {
            this.bossRepository = bossRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBossRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var bossMapped = mapper.Map<Domain.Entities.Boss>(request);

                await bossRepository.Update(bossMapped);

                return Unit.Value;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
