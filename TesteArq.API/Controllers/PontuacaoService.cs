using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.Interface;
using TesteArq.Domain.Entity;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoController : ControllerBase
    {
        public readonly IPontuacaoService _pontuacaoService;
        public PontuacaoController(IPontuacaoService pontuacaoService)
        {
            _pontuacaoService = pontuacaoService;
        }
        // GET: api/<PontuacaoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pontuacao>>> Get()
        {
            return Ok(await _pontuacaoService.GetAll());
        }

        // GET api/<PontuacaoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pontuacao>> Get(int id)
        {
            return Ok(await _pontuacaoService.GetById(id));
        }

        // POST api/<PontuacaoController>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pontuacao"></param>s
        /// <response code ="400">Dados inválidos</response>
        [HttpPost]
        public async Task<ActionResult<Pontuacao>> Post([FromBody] Pontuacao pontuacao)
        {
            return Ok(await _pontuacaoService.Add(pontuacao));
        }

        // PUT api/<PontuacaoController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Pontuacao pontuacao)
        {
            await _pontuacaoService.Update(pontuacao);
            return Ok();
        }

        // DELETE api/<PontuacaoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _pontuacaoService.Delete(id);
            return Ok();
        }
    }
}
