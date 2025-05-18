using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.Requests;
using DM106ProjectMgmt_API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DM106ProjectMgmt_API.EndPoints
{
    public static class JobTaskExtension
    {
        public static void AddEndPointsJobTask(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("task")
                .RequireAuthorization()
                .WithTags("Job Tasks");

            // Endpoints para JobTasks
            groupBuilder.MapGet("", ([FromServices] DAL<JobTask> dal) =>
            {
                var taskList = dal.Read();
                if (taskList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(taskList));
            });
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<JobTask> dal) =>
            {
                var task = dal.ReadBy(t => t.Id == id);
                if (task is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(task));
            });

            groupBuilder.MapPost("", ([FromServices] DAL<JobTask> dal, [FromBody] JobTaskRequest taskRequest) =>
            {
                dal.Create(
                    new JobTask(
                        taskRequest.Title, 
                        taskRequest.Owner, 
                        taskRequest.Status, 
                        taskRequest.MachineDesignId
                        )
                    );
                return Results.Created();
            });

            groupBuilder.MapPut("", ([FromServices] DAL<JobTask> dal, [FromBody] JobTaskEditRequest taskRequest) =>
            {
                // Verifica se o JobTask a ser editado existe
                var taskToEdit = dal.ReadBy(t => t.Id == taskRequest.Id);

                // Se o JobTask não existir, retorna um erro 404 (Not Found)
                if (taskToEdit is null) return Results.NotFound();

                // Recupera os dados do JobTask a ser editado
                taskToEdit.Title = taskRequest.Title;
                taskToEdit.Owner = taskRequest.Owner;
                taskToEdit.Status = taskRequest.Status;
                taskToEdit.MachineDesignId = taskRequest.MachineDesignId;

                // Atualiza o JobTask no banco de dados
                dal.Update(taskToEdit);

                // Retorna uma resposta indicando que a atualização foi bem-sucedida
                return Results.Created();
            });

            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<JobTask> dal, int id) =>
            {
                var task = dal.ReadBy(t => t.Id == id);
                if (task is null) return Results.NotFound();
                dal.Delete(task);
                return Results.NoContent();
            });
        }
        private static ICollection<JobTaskResponse> EntityListToResponseList(IEnumerable<JobTask> taskList)
        {
            return taskList.Select(a => EntityToResponse(a)).ToList();
        }
        private static JobTaskResponse EntityToResponse(JobTask task)
        {
            return new JobTaskResponse(
            task.Title ?? string.Empty,
            task.Owner ?? string.Empty,
            task.Status ?? string.Empty);
        }
    }
}
