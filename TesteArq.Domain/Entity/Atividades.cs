namespace TesteArq.Domain.Entity
{
    public class Atividades : BaseEntity
    {
        public Atividades(string name, int grupoAtividadesId, bool converterHoras)
        {
            Name = name;
            GrupoAtividadesId = grupoAtividadesId;
            ConverterHoras = converterHoras;
        }
        public string Name { get; set; }
        public int GrupoAtividadesId { get; set; }
        public bool ConverterHoras { get; set; }
    }
}