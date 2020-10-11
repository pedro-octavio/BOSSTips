using BOSSTips.Domain.Entities.Shared;

namespace BOSSTips.Domain.Entities
{
    public class Game : BaseEntity
    {
        public Game(string id, string name) : base(id, name) { }
    }
}
