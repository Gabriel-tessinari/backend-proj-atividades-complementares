namespace TesteArq.Application.DTOs.AtividadesDTO
{
    public class UpdateAtividadesDTO
    {
        public UpdateAtividadesDTO(int id, string nome, int grupoAtividadesId, bool converterHoras)
        {
            Id = id;
            Nome = nome;
            GrupoAtividadesId = grupoAtividadesId;
            ConverterHoras = converterHoras;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GrupoAtividadesId { get; set; }
        public bool ConverterHoras { get; set; }
    }
}