using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs.HorasComplementares;
using TesteArq.Application.Interface;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorasComplementaresController : ControllerBase
    {
        public readonly IHorasComplementaresService _horasComplementaresService;
        public HorasComplementaresController(IHorasComplementaresService horasComplementaresService)
        {
            _horasComplementaresService = horasComplementaresService;
        }
         // GET: api/<HorasComplementaresController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorasComplementaresDTO>>> Get()
        {
            return Ok(await _horasComplementaresService.GetAll());
        }

        // GET api/<HorasComplementaresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HorasComplementaresDTO>> Get(int id)
        {
                return Ok(await _horasComplementaresService.GetById(id));
        }

        // POST api/<HorasComplementaresController>
        [HttpPost]
        public async Task<ActionResult<CreateHorasComplementaresDTO>> Post([FromBody] CreateHorasComplementaresDTO horasComplementares)
        {
            return Ok(await _horasComplementaresService.Add(horasComplementares));
        }

        // PUT api/<HorasComplementaresController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] HorasComplementaresDTO horasComplementares)
        {
            await _horasComplementaresService.Update(horasComplementares);
            return Ok();
        }

        // DELETE api/<HorasComplementaresController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _horasComplementaresService.Delete(id);
            return Ok();
        }

        [HttpGet("Curso/{cursoId:int}")]
        public async Task<ActionResult<HorasComplementaresDTO>> GetByCurso(int cursoId)
        {
                return Ok(await _horasComplementaresService.GetByCurso(cursoId));
        }
        
    }
}