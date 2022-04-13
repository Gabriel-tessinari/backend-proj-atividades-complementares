namespace TesteArq.Domain.Entity
{
    public class Pontuacao : BaseEntity
    {
        public Pontuacao(decimal pontos, int numeroMaximo, int atividadeId, int cursoId)
        {
            Pontos = pontos;
            NumeroMaximo = numeroMaximo;
            AtividadeId = atividadeId;
            CursoId = cursoId;
        }
        public decimal Pontos { get; set; }
        public int NumeroMaximo { get; set; }
        public int AtividadeId { get; set; }
        public int CursoId { get; set; }
    }
}