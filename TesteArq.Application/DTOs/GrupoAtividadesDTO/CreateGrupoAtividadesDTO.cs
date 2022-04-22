namespace TesteArq.Application.DTOs.GrupoAtividadesDTO
{
    public class CreateGrupoAtividadesDTO
    {
        public CreateGrupoAtividadesDTO(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}