namespace TesteArq.Application.DTOs.GrupoAtividadesDTO
{
    public class GrupoAtividadesDTO
    {
        public GrupoAtividadesDTO(int id,string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}