using TesteArq.Application.DTOs.HorasComplementares;

namespace TesteArq.Application.Interface
{
    public interface IHorasComplementaresService
    {
        public Task<IEnumerable<HorasComplementaresDTO>> GetAll();
        public Task<HorasComplementaresDTO> GetById(int Id);
        public Task<CreateHorasComplementaresDTO> Add(CreateHorasComplementaresDTO horasComplementaresDto);
        public Task Update(HorasComplementaresDTO horasComplementaresDto);
        public Task Delete(int Id);
    }
}
