using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Tasks.Create;

public class CreateTasksUseCase
{
    public ResponseCreateTasksJson Execute(RequestTasksJson request)
    {
        return new ResponseCreateTasksJson
        {
            Id = 1,
            Name = request.Task,
        };
    }
}
