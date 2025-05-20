namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de edição de um requisito
    public record RequirementEditRequest(
        int Id, 
        string Description, 
        string Type,
        int MachineDesignId
        );
}
