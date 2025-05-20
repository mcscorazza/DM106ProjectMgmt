namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de criação de uma tarefa de projeto
    public record JobTaskRequest(
        string Title, 
        string Owner, 
        string Status,
        int MachineDesignId
        );
}
