using Microsoft.EntityFrameworkCore;
using webApidotnet.Data;
using webApidotnet.Models;

namespace webApidotnet.Services.Livros
{
    public class LivroService : ILivroInterface
    {
        private readonly AppDbContext _context;
        public LivroService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<List<LivroModel>>> ListarLivros()
        {
            ResponseModel<List<LivroModel>> resposta = new ResponseModel<List<LivroModel>>();
            try
            {
                var livros = await _context.Livro.ToListAsync();
                resposta.Dados = livros;
                resposta.Mensagem = "Todos os livros foram coletados";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
}
