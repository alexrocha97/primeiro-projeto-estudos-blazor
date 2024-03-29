using primeiro_projeto_estudos.Entidades;

namespace primeiro_projeto_estudos.Repositorios
{
    public interface IRepositorio
    {
        Task<List<Tarefa>> ObterTarefas();
    }
}