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
            try
            {
                return Ok(await _horasComplementaresService.GetAll());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET api/<HorasComplementaresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HorasComplementaresDTO>> Get(int id)
        {
            try
            {
                return Ok(await _horasComplementaresService.GetById(id));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<HorasComplementaresController>
        [HttpPost]
        public async Task<ActionResult<CreateHorasComplementaresDTO>> Post([FromBody] CreateHorasComplementaresDTO horasComplementares)
        {
            try
            {
                return Ok(await _horasComplementaresService.Add(horasComplementares));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<HorasComplementaresController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] HorasComplementaresDTO horasComplementares)
        {
            try
            {
                await _horasComplementaresService.Update(horasComplementares);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<HorasComplementaresController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _horasComplementaresService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
    }
}