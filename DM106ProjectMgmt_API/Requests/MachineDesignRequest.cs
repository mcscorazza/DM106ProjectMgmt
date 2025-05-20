using DM106ProjectMgmt.Shared.Models;

namespace DM106ProjectMgmt_API.Requests
{
    // Estrutura de um pedido de criação de um projeto de máquina
    public record MachineDesignRequest(
        string Name, 
        string DrawingCode, 
        string Client,
        ICollection<ComponentsRequest> Components = null
        );
}
