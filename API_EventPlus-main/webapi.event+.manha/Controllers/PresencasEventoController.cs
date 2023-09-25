using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces ("application/json")] 
    public class PresencasEventoController : ControllerBase
    {
        private IPresencasEventoRepository _presencasEventoRepository;

        public PresencasEventoController()
        {
            _presencasEventoRepository = new PresencasEventoRepository();
        }

        [HttpPut]
        public IActionResult Update(Guid id, PresencasEvento presencasEvento)
        {
            try
            {
                _presencasEventoRepository.Atualizar(id, presencasEvento);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
         [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_presencasEventoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(PresencasEvento presencasEvento)
        {
            try
            {
                _presencasEventoRepository.Cadastrar(presencasEvento);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);   
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _presencasEventoRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e )
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult SelectAll(Guid id)
        {
            try
            {
                return Ok(_presencasEventoRepository.Listar());
            }
            catch (Exception e )
            {
                return BadRequest(e.Message);
            }
        }
    }
}
