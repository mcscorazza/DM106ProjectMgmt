namespace DM106ProjectMgmt_API.Responses
{
    // Estrutura de resposta para o Projeto
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
