namespace TesteArq.Domain.Entity
{
    public class Atividades : BaseEntity
    {
        public Atividades(string nome, int grupoAtividadesId, bool converterHoras)
        {
            Nome = nome;
            GrupoAtividadesId = grupoAtividadesId;
            ConverterHoras = converterHoras;
        }
        public string Nome { get; set; }
        public int GrupoAtividadesId { get; set; }
        public bool ConverterHoras { get; set; }
        public virtual GrupoAtividades GrupoAtividades { get; set; }
    }
}