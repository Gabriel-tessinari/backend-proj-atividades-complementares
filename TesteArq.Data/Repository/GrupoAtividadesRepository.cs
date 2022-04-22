using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class GrupoAtividadesRepository : IGrupoAtividadesRepository
    {
        private readonly ProjDbContext _context;
        public GrupoAtividadesRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<GrupoAtividades> Add(GrupoAtividades grupoAtividades)
        {
            await _context.AddAsync(grupoAtividades);
            _context.SaveChanges();
            return grupoAtividades;
        }

        public async Task Delete(int Id)
        {
            var grupoAtividades = await _context.GrupoAtividades.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(grupoAtividades);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<GrupoAtividades>> GetAll()
        {
            var grupoAtividadess = await _context.GrupoAtividades.ToListAsync();
            return grupoAtividadess;
        }

        public async Task<GrupoAtividades> GetById(int Id)
        {
            var grupoAtividades = await _context.GrupoAtividades.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return grupoAtividades;
        }

        public async Task Update(GrupoAtividades grupoAtividades)
        {
            _context.GrupoAtividades.Update(grupoAtividades);
            await _context.SaveChangesAsync();
        }
    }
}