using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTasksJson>
            {
                new ResponseShortTasksJson
                {
                    Id = 1,
                    Task = "Arrumar o quarto",
                    Description = "Limpar e arrumar",
                    Priority = Communication.Enums.TypePriority.Media

                }
             }
        };
    }
}
