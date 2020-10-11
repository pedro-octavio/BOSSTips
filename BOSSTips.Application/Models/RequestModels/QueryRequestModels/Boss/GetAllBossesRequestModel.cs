using BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel;

namespace BOSSTips.Application.Models.RequestModels.QueryRequestModels.Boss
{
    public class GetAllBossesRequestModel : IRequest<IEnumerable<GetAllBossesResponseModel>>
    {
        [DefaultValue(10)]
        public int Quantity { get; set; }
    }
}
