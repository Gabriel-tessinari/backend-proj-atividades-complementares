namespace TesteArq.Application.DTOs.AtividadesDTO
{
    public class CreateAtividadesDTO
    {
        public CreateAtividadesDTO(string nome, int grupoAtividadesId, bool converterHoras)
        {
            Nome = nome;
            GrupoAtividadesId = grupoAtividadesId;
            ConverterHoras = converterHoras;
        }
        public string Nome { get; set; }
        public int GrupoAtividadesId { get; set; }
        public bool ConverterHoras { get; set; }
        
    }
}