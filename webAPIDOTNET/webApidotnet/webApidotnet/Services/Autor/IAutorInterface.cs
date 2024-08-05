using webApidotnet.Dto.Autor;
using webApidotnet.Models;

namespace webApidotnet.Services.IAutor {
    public interface IAutorInterface {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);

        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto);

    }
}
