
using GerenciadorDeTarefas.Application.UseCase.Tasks.Create;
using GerenciadorDeTarefas.Application.UseCase.Tasks.GetAll;
using GerenciadorDeTarefas.Application.UseCase.Tasks.GetById;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
public class TasksController : TasksBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTasksJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponsesErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTasksJson request)
    {
        var response = new CreateTasksUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponsesErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTasksById();
        var response = useCase.Execute(id);

        return Ok(response);
    }



}
