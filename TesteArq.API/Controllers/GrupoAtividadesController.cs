using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs.GrupoAtividadesDTO;
using TesteArq.Application.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoAtividadesController : ControllerBase
    {
        public readonly IGrupoAtividadesService _grupoAtividadesService;
        public GrupoAtividadesController(IGrupoAtividadesService grupoAtividadesService)
        {
            _grupoAtividadesService = grupoAtividadesService;
        }
        // GET: api/<AlunoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoAtividadesDTO>>> Get()
        {
            return Ok(await _grupoAtividadesService.GetAll());
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GrupoAtividadesDTO>> Get(int id)
        {
            return Ok(await _grupoAtividadesService.GetById(id));
        }

        // POST api/<AlunoController>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grupoAtividades"></param>s
        /// <response code ="400">Dados inválidos</response>
        [HttpPost]
        public async Task<ActionResult<CreateGrupoAtividadesDTO>> Post([FromBody] CreateGrupoAtividadesDTO grupoAtividades)
        {
            return Ok(await _grupoAtividadesService.Add(grupoAtividades));
        }

        // PUT api/<AlunoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] GrupoAtividadesDTO grupoAtividades)
        {
            await _grupoAtividadesService.Update(grupoAtividades);
            return Ok();
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _grupoAtividadesService.Delete(id);
            return Ok();
        }
        
    }
}