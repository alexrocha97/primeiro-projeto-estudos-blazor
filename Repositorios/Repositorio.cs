using primeiro_projeto_estudos.Entidades;
using primeiro_projeto_estudos.Servicos;

namespace primeiro_projeto_estudos.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly TarefaService _servicos;
        public Repositorio(TarefaService servicos)
        {
            _servicos = servicos;
        }

        public async Task<List<Tarefa>> ObterTarefas()
        {
            var result = await _servicos.GetTarefasAsync();
            return result;
        }
    }
}