namespace DM106ProjectMgmt_API.Requests
{
    public record RequirementEditRequest(
        int Id, 
        string Description, 
        string Type,
        int MachineDesignId
        );
}
