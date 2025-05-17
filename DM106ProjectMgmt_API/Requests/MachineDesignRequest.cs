using DM106ProjectMgmt.Shared.Models;

namespace DM106ProjectMgmt_API.Requests
{
    public record MachineDesignRequest(string Name, string DrawingCode, string Client, ICollection<ComponentsRequest> Components = null);
}
