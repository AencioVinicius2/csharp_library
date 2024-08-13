namespace webApidotnet.Models {
    public class LivroModel {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public LivroModel Autor { get; set; }

    }
}
