using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IGrupoAtividadesRepository
    {
        public Task<IEnumerable<GrupoAtividades>> GetAll();
        public Task<GrupoAtividades> GetById(int Id);
        public Task<GrupoAtividades> Add(GrupoAtividades grupoAtividades);
        public Task Update(GrupoAtividades grupoAtividades);
        public Task Delete(int Id);
    }
}