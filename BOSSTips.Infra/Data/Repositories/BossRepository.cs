using BOSSTips.Domain.Entities;
using BOSSTips.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOSSTips.Infra.Data.Repositories
{
    public class BossRepository : IBossRepository
    {
        private readonly DataContext dataContext;

        public BossRepository(DataContext dataContext) => this.dataContext = dataContext;

        public async Task<IEnumerable<Boss>> GetAll(int quantity)
        {
            try
            {
                var bosses = await dataContext.Bosses
                              .Include(boss => boss.Game)
                              .OrderBy(boss => boss.Game.Name)
                              .Take(quantity)
                              .ToListAsync();

                return bosses;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Boss> GetById(string id)
        {
            try
            {
                var boss = await dataContext.Bosses
                            .Include(boss => boss.Game)
                            .FirstOrDefaultAsync(boss => boss.Id == id);

                return boss;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> Add(Boss boss)
        {
            try
            {
                var addResult = await dataContext.Bosses.AddAsync(boss);

                await dataContext.SaveChangesAsync();

                var newBossId = addResult.Entity.Id;

                return newBossId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Update(Boss boss)
        {
            try
            {
                dataContext.Bosses.Update(boss);

                await dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Delete(Boss boss)
        {
            try
            {
                dataContext.Bosses.Remove(boss);

                await dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
