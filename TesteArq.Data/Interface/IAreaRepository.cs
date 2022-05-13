using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IAreaRepository
    {
        public Task<IEnumerable<Area>> GetAll();
        public Task<Area> GetById(int Id);
        public Task<Area> Add(Area area);
        public Task Update(Area area);
        public Task Delete(int Id);
    }
}
