using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs
{
    public class CursoDTO
    {
        public CursoDTO(string name, int areaId)
        {
            Name = name;
            AreaId = areaId;
        }
        public int Id { get; set; }
        public string Name { get; set; } 
        public int AreaId { get; set; } 
        public virtual Area Area { get; set; }
    }
}