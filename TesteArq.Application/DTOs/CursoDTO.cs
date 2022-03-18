namespace TesteArq.Application.DTOs
{
    public class CursoDTO
    {
        public CursoDTO(string name, int areaId)
        {
            Name = name;
            AreaId = areaId;
        }
        public string Name { get; set; } 
        public int AreaId { get; set; } 
    }
}