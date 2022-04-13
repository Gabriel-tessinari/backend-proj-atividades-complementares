namespace TesteArq.Domain.Entity
{
    public class Conversao : BaseEntity
    {
        public Conversao(int pontuacaoId, int intervaloInic, int intervaloFim, decimal pontuacao)
        {
            PontuacaoId = pontuacaoId;
            IntervaloInic = intervaloInic;
            IntervaloFim = intervaloFim;
            Pontuacao = pontuacao;
        }
        public int PontuacaoId { get; set; }
        public int IntervaloInic { get; set; }
        public int IntervaloFim { get; set; }
        public decimal Pontuacao { get; set; }
    }
}