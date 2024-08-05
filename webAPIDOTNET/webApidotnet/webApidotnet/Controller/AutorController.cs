using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApidotnet.Dto.Autor;
using webApidotnet.Models;
using webApidotnet.Services.IAutor;

namespace webApidotnet.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase {

        private readonly IAutorInterface _autorInterface;

        public AutorController(IAutorInterface autorInterface) {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores() {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

        [HttpGet("BuscarAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor) {
            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);
        }

        [HttpGet("BuscarAutorPorIdLivro/{idLivro}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorIdLivro(int idLivro) {
            var autor = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(autor);
        }

        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto) {
            var autores = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autores);
        }
    }
}
