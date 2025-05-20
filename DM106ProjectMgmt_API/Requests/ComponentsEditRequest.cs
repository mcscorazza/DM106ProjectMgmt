namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de edição de um componente
    public record ComponentsEditRequest(
        int Id, 
        string PartNumber, 
        string Description
        );
}
