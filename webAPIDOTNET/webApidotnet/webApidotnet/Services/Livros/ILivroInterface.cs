using webApidotnet.Models;

namespace webApidotnet.Services.Livros
{
    public class ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
    }
}
