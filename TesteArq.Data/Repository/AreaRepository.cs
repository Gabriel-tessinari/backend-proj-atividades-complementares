using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class AreaRepository : IAreaRepository
    {
        private readonly ProjDbContext _context;
        public AreaRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<Area> Add(Area area)
        {
            await _context.AddAsync(area);
            _context.SaveChanges();
            return area;
        }

        public async Task Delete(int Id)
        {
            var area = await _context.Area.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(area);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Area>> GetAll()
        {
            var areas = await _context.Area.ToListAsync();
            return areas;
        }

        public async Task<Area> GetById(int Id)
        {
            var area = await _context.Area.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return area;
        }

        public async Task Update(Area area)
        {
            _context.Area.Update(area);
            await _context.SaveChangesAsync();
        }
    }
}
