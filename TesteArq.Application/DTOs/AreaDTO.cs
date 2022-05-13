using TesteArq.Domain.Entity;

namespace TesteArq.Application.DTOs
{
    public class AreaDTO
    {
        public AreaDTO(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}