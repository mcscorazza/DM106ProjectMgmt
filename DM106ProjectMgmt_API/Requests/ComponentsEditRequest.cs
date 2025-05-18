namespace DM106ProjectMgmt_API.Requests
{
    public record ComponentsEditRequest(
        int Id, 
        string PartNumber, 
        string Description
        );
}
