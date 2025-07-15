using Microsoft.AspNetCore.Mvc;
using webApidotnet.Models;
using webApidotnet.Services.IAutor;

namespace webApidotnet.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;

        public LivroController(ILivroInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }

        [HttpGet("ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

    }
}
