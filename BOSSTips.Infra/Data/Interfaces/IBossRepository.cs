using BOSSTips.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BOSSTips.Infra.Data.Interfaces
{
    public interface IBossRepository
    {
        Task<IEnumerable<Boss>> GetAll(int quantity);
        Task<Boss> GetById(string id);
        Task<string> Add(Boss boss);
        Task Update(Boss boss);
        Task Delete(Boss boss);
    }
}
