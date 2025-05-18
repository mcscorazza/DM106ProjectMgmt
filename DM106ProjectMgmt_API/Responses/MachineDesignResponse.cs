namespace DM106ProjectMgmt_API.Responses
{
    public record MachineDesignResponse(
        int Id, 
        string Name, 
        string DrawingCode, 
        string Client, 
        List<JobTaskResponse> JobTasks,
        List<RequirementResponse> Requitements,
        List<ComponentsResponse> Components
        );
}
