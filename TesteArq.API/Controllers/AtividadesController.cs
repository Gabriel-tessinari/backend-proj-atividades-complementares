using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs.AtividadesDTO;
using TesteArq.Application.Interface;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtividadesController : ControllerBase
    {
        public readonly IAtividadesService _atividadesService;
        public AtividadesController(IAtividadesService atividadesService)
        {
            _atividadesService = atividadesService;
        }
        // GET: api/<AlunoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AtividadesDTO>>> Get()
        {
            return Ok(await _atividadesService.GetAll());
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AtividadesDTO>> Get(int id)
        {
            return Ok(await _atividadesService.GetById(id));
        }

        // POST api/<AlunoController>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="atividades"></param>s
        /// <response code ="400">Dados inválidos</response>
        [HttpPost]
        public async Task<ActionResult<CreateAtividadesDTO>> Post([FromBody] CreateAtividadesDTO atividades)
        {
            return Ok(await _atividadesService.Add(atividades));
        }

        // PUT api/<AlunoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateAtividadesDTO atividades)
        {
            await _atividadesService.Update(atividades);
            return Ok();
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _atividadesService.Delete(id);
            return Ok();
        }
        
    }
}