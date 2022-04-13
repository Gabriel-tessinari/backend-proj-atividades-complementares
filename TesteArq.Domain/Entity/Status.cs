namespace TesteArq.Domain.Entity
{
    public class Status : BaseEntity
    {
        public Status(string descricao)
        {
            Descricao = descricao;
        }
        public string Descricao { get; set; }
    }
}