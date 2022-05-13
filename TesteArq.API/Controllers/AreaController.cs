using Microsoft.AspNetCore.Mvc;
using TesteArq.Application.DTOs;
using TesteArq.Application.Interface;

namespace TesteArq.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        public readonly IAreaService _areaService;
        public AreaController(IAreaService areaService)
        {
            _areaService = areaService;
        }
        // GET: api/<AreaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaDTO>>> Get()
        {
            return Ok(await _areaService.GetAll());
        }

        // GET api/<AreaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaDTO>> Get(int id)
        {
            return Ok(await _areaService.GetById(id));
        }

        // POST api/<AreaController>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>s
        /// <response code ="400">Dados inválidos</response>
        [HttpPost]
        public async Task<ActionResult<AreaDTO>> Post([FromBody] AreaDTO area)
        {
            return Ok(await _areaService.Add(area));
        }

        // PUT api/<AreaController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] AreaDTO area)
        {
            await _areaService.Update(area);
            return Ok();
        }

        // DELETE api/<AreaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _areaService.Delete(id);
            return Ok();
        }
    }
}
