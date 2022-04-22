using TesteArq.Application.DTOs.GrupoAtividadesDTO;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Interface
{
    public interface IGrupoAtividadesService
    {
        public Task<IEnumerable<GrupoAtividadesDTO>> GetAll();
        public Task<GrupoAtividadesDTO> GetById(int Id);
        public Task<CreateGrupoAtividadesDTO> Add(CreateGrupoAtividadesDTO atividadesDTO);
        public Task Update(GrupoAtividadesDTO atividadesDTO);
        public Task Delete(int Id);
    }
}