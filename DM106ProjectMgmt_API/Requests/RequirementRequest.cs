namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de criação de um requisito
    public record RequirementRequest(
        string Description, 
        string Type,
        int MachineDesignId
        );
}
