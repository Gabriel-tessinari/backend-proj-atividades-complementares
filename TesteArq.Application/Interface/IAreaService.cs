using TesteArq.Application.DTOs;

namespace TesteArq.Application.Interface
{
    public interface IAreaService
    {
        public Task<IEnumerable<AreaDTO>> GetAll();
        public Task<AreaDTO> GetById(int Id);
        public Task<AreaDTO> Add(AreaDTO areaDto);
        public Task Update(AreaDTO areaDto);
        public Task Delete(int Id);
    }
}
