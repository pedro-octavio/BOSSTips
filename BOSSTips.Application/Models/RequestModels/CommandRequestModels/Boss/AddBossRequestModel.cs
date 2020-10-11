using BOSSTips.Application.Models.ResponseModels.CommandResponseModels.Boss;
using MediatR;

namespace BOSSTips.Application.Models.RequestModels.CommandRequestModels.Boss
{
    public class AddBossRequestModel : IRequest<AddBossResponseModel>
    {
        public string GameId { get; set; }
        public string Name { get; set; }
        public string Tips { get; set; }
    }
}
