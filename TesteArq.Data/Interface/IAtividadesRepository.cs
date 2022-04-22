using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IAtividadesRepository
    {
        public Task<IEnumerable<Atividades>> GetAll();
        public Task<Atividades> GetById(int Id);
        public Task<Atividades> Add(Atividades atividades);
        public Task Update(Atividades atividades);
        public Task Delete(int Id);
    }
}