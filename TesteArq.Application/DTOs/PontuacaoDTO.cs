using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs
{
    public class PontuacaoDTO
    {
        public PontuacaoDTO(decimal pontos, int numeroMaximo, int atividadeId, int cursoId)
        {
            Pontos = pontos;
            NumeroMaximo = numeroMaximo;
            AtividadeId = atividadeId;
            CursoId = cursoId;
        }
        public int Id { get; set; }
        public decimal Pontos { get; set; }
        public int NumeroMaximo { get; set; }
        public int AtividadeId { get; set; }
        public int CursoId { get; set; }

    }
}