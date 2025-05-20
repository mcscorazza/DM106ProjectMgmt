namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de edição de uma tarefa de projeto
    public record JobTaskEditRequest(
        int Id, 
        string Title, 
        string Owner, 
        string Status,
        int MachineDesignId
        );
}
