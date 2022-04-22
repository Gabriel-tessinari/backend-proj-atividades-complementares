using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;


namespace TesteArq.Data.Repository
{
    public class AtividadesRepository : IAtividadesRepository
    {
        private readonly ProjDbContext _context;
        public AtividadesRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<Atividades> Add(Atividades atividades)
        {
            await _context.AddAsync(atividades);
            _context.SaveChanges();
            return atividades;
        }

        public async Task Delete(int Id)
        {
            var atividades = await _context.Atividades.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(atividades);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Atividades>> GetAll()
        {
            var atividadess = await _context.Atividades.Include(x => x.GrupoAtividades).ToListAsync();
            return atividadess;
        }

        public async Task<Atividades> GetById(int Id)
        {
            var atividades = await _context.Atividades.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return atividades;
        }

        public async Task Update(Atividades atividades)
        {
            _context.Atividades.Update(atividades);
            await _context.SaveChangesAsync();
        }
    }
}