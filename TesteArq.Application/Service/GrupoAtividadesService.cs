using AutoMapper;
using TesteArq.Application.DTOs.GrupoAtividadesDTO;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class GrupoAtividadesService : IGrupoAtividadesService
    {
        private readonly IGrupoAtividadesRepository _grupoAtividadesRepository;
        private readonly IMapper _mapper;

        public GrupoAtividadesService(IGrupoAtividadesRepository grupoAtividadesRepository, IMapper mapper)
        {
            _grupoAtividadesRepository = grupoAtividadesRepository;
            _mapper = mapper;
        }
        public async Task<CreateGrupoAtividadesDTO> Add(CreateGrupoAtividadesDTO grupoAtividadesDTO)
        {
            var grupoAtividadesEntity = _mapper.Map<GrupoAtividades>(grupoAtividadesDTO);
            await _grupoAtividadesRepository.Add(grupoAtividadesEntity);
            return grupoAtividadesDTO;
        }

        public async Task Delete(int Id)
        {
            await _grupoAtividadesRepository.Delete(Id);
        }

        public async Task<IEnumerable<GrupoAtividadesDTO>> GetAll()
        {
            var grupoAtividadesEntity = await _grupoAtividadesRepository.GetAll();
            return _mapper.Map<IEnumerable<GrupoAtividadesDTO>>(grupoAtividadesEntity);

        }

        public async Task<GrupoAtividadesDTO> GetById(int Id)
        {
            var grupoAtividadesEntity = await _grupoAtividadesRepository.GetById(Id);
            return _mapper.Map<GrupoAtividadesDTO>(grupoAtividadesEntity);
        }

        public async Task Update(GrupoAtividadesDTO grupoAtividadesDTO)
        {
            var grupoAtividadesEntity = _mapper.Map<GrupoAtividades>(grupoAtividadesDTO);
            await _grupoAtividadesRepository.Update(grupoAtividadesEntity);
        }
    }
}