using MediatR;

namespace BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss
{
    public class DeleteBossRequestModel : IRequest
    {
        public string Id { get; set; }
    }
}
