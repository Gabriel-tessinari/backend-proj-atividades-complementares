using System.Linq.Expressions;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Interface
{
    public interface IHorasComplementaresRepository
    {
        public Task<IEnumerable<HorasComplementares>> GetAll();
        public Task<HorasComplementares> GetById(int Id);
        public Task<HorasComplementares> Add(HorasComplementares horasComplementares);
        public Task Update(HorasComplementares horasComplementares);
        public Task Delete(int Id);
        public Task<IEnumerable<HorasComplementares>> FindBy(Expression<Func<HorasComplementares, bool>> predicate);
    }
}
