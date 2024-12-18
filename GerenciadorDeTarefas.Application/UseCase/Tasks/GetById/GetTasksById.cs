using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.GetById;

public class GetTasksById
{
    public ResponseTasksJson Execute(int id)
    {
        return new ResponseTasksJson
        {
            Id = id,
            Task = "Arrumar o quarto",
            Description = "Limpar e arrumar",
            Priority = Communication.Enums.TypePriority.Media,
            Date = DateTime.Now,
            Status = Communication.Enums.TypeStatus.EmAndamento
        };
    }
}
