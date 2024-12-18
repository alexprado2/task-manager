
using GerenciadorDeTarefas.Application.UseCase.Tasks.Create;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
public class TarefasController : TarefasBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTasksJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponsesErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTasksJson request)
    {
        var response = new CreateTasksUseCase().Execute(request);
        return Created(string.Empty, response);
    }

}
