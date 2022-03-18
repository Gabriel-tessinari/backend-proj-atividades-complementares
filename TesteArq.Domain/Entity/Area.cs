namespace TesteArq.Domain.Entity
{
    public class Area : BaseEntity
    {
        public Area(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}