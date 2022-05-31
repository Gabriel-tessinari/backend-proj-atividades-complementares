namespace TesteArq.Domain.Entity
{
    public class Curso : BaseEntity
    {
        public Curso(string name, decimal pontuacaoMin, int areaId)
        {
            Name = name;
            AreaId = areaId;
            PontuacaoMin = pontuacaoMin;
        }
        public string Name { get; set; }
        public int AreaId { get; set; }
        public decimal PontuacaoMin { get; set; }
        public virtual Area Area { get; set; }
    }
}