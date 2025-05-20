namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de edição de um projeto de máquina
    public record MachineDesignEditRequest(
        int Id, 
        string Name, 
        string DrawingCode, 
        string Client
        );
}
