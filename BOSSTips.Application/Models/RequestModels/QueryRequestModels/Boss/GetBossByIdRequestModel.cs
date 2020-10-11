using BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss;
using MediatR;

namespace BOSSTips.Application.Models.RequestModels.QueryRequestModels.Boss
{
    public class GetBossByIdRequestModel : IRequest<GetBossByIdResponseModel>
    {
        public string Id { get; set; }
    }
}
