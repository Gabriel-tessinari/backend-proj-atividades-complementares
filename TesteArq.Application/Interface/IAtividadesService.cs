using TesteArq.Application.DTOs.AtividadesDTO;

namespace TesteArq.Application.Interface
{
    public interface IAtividadesService
    {
        public Task<IEnumerable<AtividadesDTO>> GetAll();
        public Task<AtividadesDTO> GetById(int Id);
        public Task<CreateAtividadesDTO> Add(CreateAtividadesDTO atividadesDTO);
        public Task Update(UpdateAtividadesDTO atividadesDTO);
        public Task Delete(int Id);
    }
}