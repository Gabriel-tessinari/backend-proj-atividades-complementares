namespace TesteArq.Domain.Entity
{
    public class HorasComplementares : BaseEntity
    {
        public HorasComplementares(int alunoId, int pontuacaoId, string certificado, int statusId, string observacao, int horas)
        {
            AlunoId = alunoId;
            PontuacaoId = pontuacaoId;
            Certificado = certificado;
            StatusId = statusId;
            Observacao = observacao;
            Horas = horas;
        }
        public int AlunoId { get; set; }
        public int PontuacaoId { get; set; }
        public string Certificado { get; set; }
        public int StatusId { get; set; }
        public string? Observacao { get; set; }
        public int Horas { get; set; }
        public virtual Aluno? Aluno { get; set; }
        public virtual Pontuacao? Pontuacao { get; set; }
        public virtual Status? Status { get; set; }
    }
}
