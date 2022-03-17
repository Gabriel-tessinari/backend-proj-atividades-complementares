using AutoMapper;
using TesteArq.Application.DTOs.HorasComplementares;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class HorasComplementaresSerivce : IHorasComplementaresService
    {
        private readonly IHorasComplementaresRepository _horasComplementaresRepository;
        private readonly IMapper _mapper;

        public HorasComplementaresSerivce(IHorasComplementaresRepository horasComplementaresRepository, IMapper mapper)
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
    }
}