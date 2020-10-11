using BOSSTips.Domain.Entities.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOSSTips.Domain.Entities
{
    public class Boss : BaseEntity
    {
        public Boss(string Id = null, string Name = null, string Tips = null, string GameId = null) : base(Id, Name)
        {
            this.Tips = Tips;
            this.GameId = GameId;
        }

        [MaxLength(7200)]
        public string Tips { get; private set; }
        [ForeignKey("games")]
        [MaxLength(10)]
        public string GameId { get; private set; }

        public Game Game { get; private set; }
    }
}
