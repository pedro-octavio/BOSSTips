using MediatR;

namespace BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss
{
    public class UpdateBossRequestModel : IRequest
    {
        public string Id { get; set; }
        public string GameId { get; set; }
        public string Name { get; set; }
        public string Tips { get; set; }
    }
}
