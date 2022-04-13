namespace TesteArq.Application.DTOs.HorasComplementares
{
    public class UpdateStatusHorasComplementaresDTO
    {
        public UpdateStatusHorasComplementaresDTO(int id, int statusId, string? observacao)
        {
            Id = id;
            StatusId = statusId;
            Observacao = observacao;
        }
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string? Observacao { get; set; }
    }
}