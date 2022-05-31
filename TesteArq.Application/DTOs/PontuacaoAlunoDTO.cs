using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs
{
    public class PontuacaoAlunoDTO
    {
        public PontuacaoAlunoDTO(bool aprovado, decimal pontuacao)
        {
            Aprovado = aprovado;
            Pontuacao = pontuacao;
        }
        public bool Aprovado { get; set; }
        public decimal Pontuacao { get; set; }
    }
}