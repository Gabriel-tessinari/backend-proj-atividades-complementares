namespace TesteArq.Domain.Entity
{
    public class Curso : BaseEntity
    {
        public Curso(string name, int areaId)
        {
            Name = name;
            AreaId = areaId;
        }
        public string Name { get; set; }
        public int AreaId { get; set; }
        public virtual Area? Area { get; set; }
    }
}