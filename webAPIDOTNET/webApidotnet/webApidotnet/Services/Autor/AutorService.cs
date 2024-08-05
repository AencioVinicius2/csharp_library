using webApidotnet.Data;
using webApidotnet.Models;

namespace webApidotnet.Services.Autor {
    public class AutorService : IAutorService {
        private readonly AppDbContext _context;
        public AutorService(AppDbContext context) {
            _context = context;
        }
        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor) {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro) {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<AutorModel>>> ListarAutores() {
            throw new NotImplementedException();
        }
    }
}
