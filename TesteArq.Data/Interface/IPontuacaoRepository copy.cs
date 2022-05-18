using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IPontuacaoRepository
    {
        public Task<IEnumerable<Pontuacao>> GetAll();
        public Task<Pontuacao> GetById(int Id);
        public Task<Pontuacao> Add(Pontuacao pontuacao);
        public Task Update(Pontuacao pontuacao);
        public Task Delete(int Id);
    }
}
