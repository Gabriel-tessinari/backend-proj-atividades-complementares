using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class AreaService : IAreaService
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public AreaService(IAreaRepository areaRepository, IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }
        public async Task<AreaDTO> Add(AreaDTO areaDto)
        {
            var areaEntity = _mapper.Map<Area>(areaDto);
            await _areaRepository.Add(areaEntity);
            return areaDto;
        }

        public async Task Delete(int Id)
        {
            await _areaRepository.Delete(Id);
        }

        public async Task<IEnumerable<AreaDTO>> GetAll()
        {
            var areaEntity = await _areaRepository.GetAll();
            return _mapper.Map<IEnumerable<AreaDTO>>(areaEntity);
        }

        public async Task<AreaDTO> GetById(int Id)
        {
            var areaEntity = await _areaRepository.GetById(Id);
            return _mapper.Map<AreaDTO>(areaEntity);
        }

        public async Task Update(AreaDTO areaDto)
        {
            var areaEntity = _mapper.Map<Area>(areaDto);
            await _areaRepository.Update(areaEntity);
        }
    }
}
