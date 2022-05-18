using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;
using TesteArq.Data.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Service
{
    public class PontuacaoService : IPontuacaoService
    {
        private readonly IPontuacaoRepository _pontuacaoRepository;
        private readonly ICursoRepository _cursoRepository;
        private readonly IAtividadesRepository _atividadeRepository;

        private readonly IMapper _mapper;

        public PontuacaoService(IPontuacaoRepository pontuacaoRepository, ICursoRepository cursoRepository,IAtividadesRepository atividadeRepository, IMapper mapper)
        {
            _pontuacaoRepository = pontuacaoRepository;
            _cursoRepository = cursoRepository;
            _atividadeRepository = atividadeRepository;
            _mapper = mapper;
        }
        public async Task<Pontuacao> Add(Pontuacao pontuacao)
        {
            if((await _atividadeRepository.GetById(pontuacao.AtividadeId)) == null)
                throw new Exception("Atividade não existe");
            if((await _cursoRepository.GetById(pontuacao.CursoId)) == null)
                throw new Exception("Curso não existe");


            await _pontuacaoRepository.Add(pontuacao);
            return pontuacao;
        }

        public async Task Delete(int Id)
        {
            await _pontuacaoRepository.Delete(Id);
        }

        public async Task<IEnumerable<Pontuacao>> GetAll()
        {
            var pontuacaoEntity = await _pontuacaoRepository.GetAll();
            return _mapper.Map<IEnumerable<Pontuacao>>(pontuacaoEntity);
        }

        public async Task<Pontuacao> GetById(int Id)
        {
            return await _pontuacaoRepository.GetById(Id);
        }

        public async Task Update(Pontuacao pontuacao)
        {
            if((await _atividadeRepository.GetById(pontuacao.AtividadeId)) == null)
                throw new Exception("Atividade não existe");
            if((await _cursoRepository.GetById(pontuacao.CursoId)) == null)
                throw new Exception("Curso não existe");

            await _pontuacaoRepository.Update(pontuacao);
        }
    }
}
