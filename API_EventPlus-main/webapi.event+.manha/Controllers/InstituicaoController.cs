using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;
using webapi.event_.manha.Repositories;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InstituicaoController : ControllerBase
    {
        private IInstuicaoRepository _instituicaoRepository;

        public InstituicaoController()
        {
            _instituicaoRepository= new InstituicaoRepository();
        }

        [HttpPut]

        public IActionResult Update(Guid id, InstituicaoRepository instituicao)
        {
            try
            {
                _instituicaoRepository.Atualizar(id, instituicao);
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
                return Ok(_instituicaoRepository.BuscarPorId(id));
              
            }
            catch (Exception e )
            {

               return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post (Instituicao instituicao)
        {
            try
            {
                _instituicaoRepository.Cadastrar(instituicao);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
