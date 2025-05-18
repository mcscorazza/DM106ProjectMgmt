namespace DM106ProjectMgmt_API.Requests
{
    public record JobTaskRequest(
        string Title, 
        string Owner, 
        string Status,
        int MachineDesignId
        );
}
