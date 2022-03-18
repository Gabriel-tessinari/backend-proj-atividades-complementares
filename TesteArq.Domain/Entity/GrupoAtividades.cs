namespace TesteArq.Domain.Entity
{
    public class GrupoAtividades : BaseEntity
    {
        public GrupoAtividades(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}