using TesteArq.Application.DTOs;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Interface
{
    public interface IPontuacaoService
    {
        public Task<IEnumerable<Pontuacao>> GetAll();
        public Task<Pontuacao> GetById(int Id);
        public Task<Pontuacao> Add(Pontuacao pontuacaoDto);
        public Task Update(Pontuacao pontuacaoDto);
        public Task Delete(int Id);
    }
}
