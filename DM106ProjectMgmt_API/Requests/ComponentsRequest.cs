namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de criação de um componente
    public record ComponentsRequest(
        string PartNumber, 
        string Description
        );
}
