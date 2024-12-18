using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseShortTasksJson
{
    public int Id { get; set; }
    public string Task { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TypePriority Priority { get; set; }
}
