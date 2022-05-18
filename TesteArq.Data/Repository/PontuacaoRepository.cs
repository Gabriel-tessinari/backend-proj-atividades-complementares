using Microsoft.EntityFrameworkCore;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Repository
{
    public class PontuacaoRepository : IPontuacaoRepository
    {
        private readonly ProjDbContext _context;
        public PontuacaoRepository(ProjDbContext Context)
        {
            _context = Context;
        }
        public async Task<Pontuacao> Add(Pontuacao pontuacao)
        {
            await _context.AddAsync(pontuacao);
            _context.SaveChanges();
            return pontuacao;
        }

        public async Task Delete(int Id)
        {
            var pontuacao = await _context.Pontuacao.Where(x => x.Id == Id).FirstOrDefaultAsync();
            _context.Remove(pontuacao);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pontuacao>> GetAll()
        {
            var pontuacaos = await _context.Pontuacao.ToListAsync();
            return pontuacaos;
        }

        public async Task<Pontuacao> GetById(int Id)
        {
            var pontuacao = await _context.Pontuacao.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return pontuacao;
        }

        public async Task Update(Pontuacao pontuacao)
        {
            _context.Pontuacao.Update(pontuacao);
            await _context.SaveChangesAsync();
        }
    }
}
