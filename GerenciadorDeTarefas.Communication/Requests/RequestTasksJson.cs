using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestTasksJson
{
    public string Task {  get; set; } = string.Empty;

    public string Description {  get; set; } = string.Empty;

    public TypePriority Priority { get; set; }

    public DateTime Date { get; set; }

    public TypeStatus Status { get; set; }

}
