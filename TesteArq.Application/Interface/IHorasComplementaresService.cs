using TesteArq.Application.DTOs;
using TesteArq.Application.DTOs.HorasComplementares;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Interface
{
    public interface IHorasComplementaresService
    {
        public Task<IEnumerable<HorasComplementaresDTO>> GetAll();
        public Task<HorasComplementaresDTO> GetById(int Id);
        public Task<CreateHorasComplementaresDTO> Add(CreateHorasComplementaresDTO horasComplementaresDto);
        public Task Update(HorasComplementaresDTO horasComplementaresDto);
        public Task Delete(int Id);
        public Task<IEnumerable<HorasComplementares>> GetByCurso(int cursoId);
        public Task<HorasComplementaresDTO> UpdateStatus(UpdateStatusHorasComplementaresDTO updateStatus);
        public Task<PontuacaoAlunoDTO> GetPontuacao(int alunoId);
    }
}
