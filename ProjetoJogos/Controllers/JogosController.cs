using Microsoft.AspNetCore.Mvc;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
        private readonly IJogosRepository _jogosRepository;

        public JogoController(IJogosRepository jogosRepository)
        {
            _jogosRepository = jogosRepository;
        }

        [HttpPost] // metodo de cadastrar um jogo por meio de post
        public IActionResult Post(Jogo jogo)
        {
            try
            {
                _jogosRepository.Cadastrar(jogo);
                return Created();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("BuscarPorId/{Id}")] // get de Buscar um Jogo atraves do id 
        public IActionResult Get(Guid Id)
        {
            try
            {
                Jogo novoJogo = _jogosRepository.BuscarPorId(Id);
                return Ok(novoJogo);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")] // Delete por id 
        public IActionResult Delete(Guid id)
        {
            try
            {
                _jogosRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpGet] //get de listagem
        public IActionResult Get()
        {
            try
            {
                List<Jogo> listaJogos = _jogosRepository.List();
                return Ok(listaJogos);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")] //Put de Atualizar
        public IActionResult Put(Guid id, Jogo jogo)
        {
            try
            {
                _jogosRepository.Atualizar(id, jogo);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


    }
}