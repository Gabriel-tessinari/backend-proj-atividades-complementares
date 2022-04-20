using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs.HorasComplementares
{
    public class HorasComplementaresDTO
    {
        public HorasComplementaresDTO(int alunoId, int pontuacaoId, string certificado, int statusId, string observacao, int horas, DateTime data)
        {
            AlunoId = alunoId;
            PontuacaoId = pontuacaoId;
            Certificado = certificado;
            StatusId = statusId;
            Observacao = observacao;
            Horas = horas;
            Data = data;
        }
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int PontuacaoId { get; set; }
        public string Certificado { get; set; }
        public int StatusId { get; set; }
        public string? Observacao { get; set; }
        public int Horas { get; set; }
        public DateTime Data { get; set; }

        public virtual Aluno? Aluno { get; set; }
        public virtual Pontuacao? Pontuacao { get; set; }
        public virtual Status? Status { get; set; }

    }
}