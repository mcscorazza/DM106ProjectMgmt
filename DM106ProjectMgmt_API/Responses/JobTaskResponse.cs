namespace DM106ProjectMgmt_API.Responses
{
    public record JobTaskResponse(int Id, string Title, string Owner, string Status, int MachineDesignId, string DesignName);
}
