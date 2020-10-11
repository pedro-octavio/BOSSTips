using BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss;
using BOSSTips.Infra.Data.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BOSSTips.Application.Handlers.CommandHandlers.Boss
{
    public class DeleteBossCommandHandler : IRequestHandler<DeleteBossRequestModel>
    {
        private readonly IBossRepository bossRepository;

        public DeleteBossCommandHandler(IBossRepository bossRepository) => this.bossRepository = bossRepository;

        public async Task<Unit> Handle(DeleteBossRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var boss = await bossRepository.GetById(request.Id);

                await bossRepository.Delete(boss);

                return Unit.Value;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
