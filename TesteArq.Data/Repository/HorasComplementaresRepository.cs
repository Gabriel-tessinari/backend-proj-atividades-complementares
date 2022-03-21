using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class HorasComplementaresRepository : IHorasComplementaresRepository
    {
        private readonly ProjDbContext _context;
        public HorasComplementaresRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<HorasComplementares> Add(HorasComplementares horasComplementares)
        {
            await _context.AddAsync(horasComplementares);
            _context.SaveChanges();
            return horasComplementares;
        }

        public async Task Delete(int Id)
        {
            var horasComplementares = await _context.HorasComplementares.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(horasComplementares);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HorasComplementares>> GetAll()
        {
            var horasComplementaress = await _context.HorasComplementares.Include(x => x.Aluno).ToListAsync();
            return horasComplementaress;
        }

        public async Task<HorasComplementares> GetById(int Id)
        {
            var horasComplementares = await _context.HorasComplementares.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return horasComplementares;
        }

        public async Task Update(HorasComplementares horasComplementares)
        {
            _context.HorasComplementares.Update(horasComplementares);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<HorasComplementares>> FindBy(Expression<Func<HorasComplementares, bool>> predicate)
        {
            return await _context.Set<HorasComplementares>().Where(predicate)
                                    .Include(x => x.Aluno).ToListAsync();
        }
    }
}
