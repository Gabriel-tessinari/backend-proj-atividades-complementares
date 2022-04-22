using AutoMapper;
using TesteArq.Application.DTOs.AtividadesDTO;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class AtividadesService : IAtividadesService
    {
        private readonly IAtividadesRepository _atividadesRepository;
        private readonly IMapper _mapper;

        public AtividadesService(IAtividadesRepository alunoRepository, IMapper mapper)
        {
            _atividadesRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<CreateAtividadesDTO> Add(CreateAtividadesDTO atividadesDTO)
        {
            var alunoEntity = _mapper.Map<Atividades>(atividadesDTO);
            await _atividadesRepository.Add(alunoEntity);
            return atividadesDTO;
        }

        public async Task Delete(int Id)
        {
            await _atividadesRepository.Delete(Id);
        }

        public async Task<IEnumerable<AtividadesDTO>> GetAll()
        {
            var alunoEntity = await _atividadesRepository.GetAll();
            return _mapper.Map<IEnumerable<AtividadesDTO>>(alunoEntity);
        }

        public async Task<AtividadesDTO> GetById(int Id)
        {
            var alunoEntity = await _atividadesRepository.GetById(Id);
            return _mapper.Map<AtividadesDTO>(alunoEntity);
        }

        public async Task Update(UpdateAtividadesDTO atividadesDTO)
        {
            var alunoEntity = _mapper.Map<Atividades>(atividadesDTO);
            await _atividadesRepository.Update(alunoEntity);
        }
    }
}