using webApidotnet.Models;

namespace webApidotnet.Services.Autor {
    public interface IAutorService {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);

    }
}
