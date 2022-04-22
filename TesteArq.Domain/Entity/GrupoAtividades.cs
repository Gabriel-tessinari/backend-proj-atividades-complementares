namespace TesteArq.Domain.Entity
{
    public class GrupoAtividades : BaseEntity
    {
        public GrupoAtividades(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}