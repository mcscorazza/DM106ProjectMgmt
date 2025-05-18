namespace DM106ProjectMgmt_API.Requests
{
    public record RequirementRequest(
        string Description, 
        string Type,
        int MachineDesignId
        );
}
