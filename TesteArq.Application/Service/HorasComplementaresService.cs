using AutoMapper;
using TesteArq.Application.DTOs.HorasComplementares;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class HorasComplementaresService : IHorasComplementaresService
    {
        private readonly IHorasComplementaresRepository _horasComplementaresRepository;
        private readonly IMapper _mapper;

        public HorasComplementaresService(IHorasComplementaresRepository horasComplementaresRepository, IMapper mapper)
        {
            _horasComplementaresRepository = horasComplementaresRepository;
            _mapper = mapper;
        }
        public async Task<CreateHorasComplementaresDTO> Add(CreateHorasComplementaresDTO horasComplementaresDto)
        {
            var horasComplementaresEntity = _mapper.Map<HorasComplementares>(horasComplementaresDto);
            await _horasComplementaresRepository.Add(horasComplementaresEntity);
            return horasComplementaresDto;
        }

        public async Task Delete(int Id)
        {
            await _horasComplementaresRepository.Delete(Id);
        }

        public async Task<IEnumerable<HorasComplementaresDTO>> GetAll()
        {
            var horasComplementaresEntity = await _horasComplementaresRepository.GetAll();
            return _mapper.Map<IEnumerable<HorasComplementaresDTO>>(horasComplementaresEntity);

        }

        public async Task<HorasComplementaresDTO> GetById(int Id)
        {
            var horasComplementaresEntity = await _horasComplementaresRepository.GetById(Id);
            return _mapper.Map<HorasComplementaresDTO>(horasComplementaresEntity);
        }

        public async Task Update(HorasComplementaresDTO horasComplementares)
        {
            var horasComplementaresEntity = _mapper.Map<HorasComplementares>(horasComplementares);
            await _horasComplementaresRepository.Update(horasComplementaresEntity);
        }

        public async Task<IEnumerable<HorasComplementares>> GetByCurso(int cursoId)
        {
            var horasComplementaresEntity = await _horasComplementaresRepository.FindBy(x => x.Aluno.CursoId == cursoId);
            return horasComplementaresEntity;
        }

        public async Task<HorasComplementaresDTO> UpdateStatus(UpdateStatusHorasComplementaresDTO updateStatus)
        {
            if(updateStatus.StatusId == 2 && updateStatus.Observacao == null)
                throw new Exception("Se o status é recusado observação deve ser preenchido");

            var horasComplementaresReal = await _horasComplementaresRepository.GetById(updateStatus.Id);

            horasComplementaresReal.StatusId = updateStatus.StatusId;
            horasComplementaresReal.Observacao = updateStatus.Observacao;

            await _horasComplementaresRepository.Update(horasComplementaresReal);

            return _mapper.Map<HorasComplementaresDTO>(horasComplementaresReal);
;

        }

    }
}