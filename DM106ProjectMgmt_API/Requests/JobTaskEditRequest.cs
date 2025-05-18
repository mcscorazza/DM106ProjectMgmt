namespace DM106ProjectMgmt_API.Requests
{
    public record JobTaskEditRequest(
        int Id, 
        string Title, 
        string Owner, 
        string Status,
        int MachineDesignId
        );
}
