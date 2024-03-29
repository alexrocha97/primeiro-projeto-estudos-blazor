using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;
using primeiro_projeto_estudos.Entidades;

namespace primeiro_projeto_estudos.Servicos
{
    public class TarefaService
    {
        private readonly HttpClient _httpClient;

        public TarefaService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            string jsonFilePath = "E:/Projetos/Blazor/primeiro-projeto-estudos/wwwroot/dados/tarefas.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            var tarefas = JsonSerializer.Deserialize<List<Tarefa>>(jsonContent);
            
            var listaTarefas = new List<Tarefa>();
            return listaTarefas;

            // var result = await _httpClient.GetFromJsonAsync<List<Tarefa>>("E:/Projetos/Blazor/primeiro-projeto-estudos/wwwroot/dados/tarefas.json");
            // return tarefas;
        }

        public Tarefa AdicionarTarefa(string novaTarefa)
        {
            if(!string.IsNullOrWhiteSpace(novaTarefa))
            {
                var tarefa = new Tarefa
                {
                    Descricao = novaTarefa,
                    DataCriacao = DateTime.Now,
                    Concluida = false
                };
                return tarefa;
            }
            return null;
        }

        public List<Tarefa> RemoveTarefa(Guid id, List<Tarefa> tarefas)
        {
            tarefas.RemoveAll(t => t.ID == id);
            return tarefas;
        }
    }
}