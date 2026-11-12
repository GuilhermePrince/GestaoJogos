using GestaoJogos.Repositories;

namespace GestaoJogos.Services
{
    public class JogoService
    {
        private readonly JogoRepository _repository;

        public JogoService(JogoRepository repository)
        {
            _repository = repository;
        }

        public List<Jogo> Listar()
        {
            return _repository.Listar();
        }
    }
}