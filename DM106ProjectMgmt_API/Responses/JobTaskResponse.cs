namespace DM106ProjectMgmt_API.Responses
{
    // Estrutura de resposta para as Tarefas de um Projeto
    public record JobTaskResponse(
        string Title, 
        string Owner, 
        string Status
        );
}
