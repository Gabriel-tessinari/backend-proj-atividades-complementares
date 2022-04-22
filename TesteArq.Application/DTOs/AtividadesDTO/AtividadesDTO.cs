using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs.AtividadesDTO
{
    public class AtividadesDTO
    {
        public AtividadesDTO(string nome, int grupoAtividadesId, bool converterHoras)
        {
            Nome = nome;
            GrupoAtividadesId = grupoAtividadesId;
            ConverterHoras = converterHoras;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GrupoAtividadesId { get; set; }
        public bool ConverterHoras { get; set; }
        public virtual GrupoAtividades GrupoAtividades { get; set; }
    }
}