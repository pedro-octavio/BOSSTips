using BOSSTips.Domain.Entities;

namespace BOSSTips.Application.Models.ResponseModels.QueryResponseModels.Boss
{
    public class GetBossByIdResponseModel
    {
        public GetBossByIdResponseModel(string id, string name, string tips, Game game)
        {
            Id = id;
            Name = name;
            Tips = tips;
            Game = game;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Tips { get; private set; }

        public Game Game { get; private set; }
    }
}
