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
            // Endpoints para JobTasks
            app.MapGet("/task", ([FromServices] DAL<JobTask> dal) =>
            {
                var taskList = dal.Read();
                if (taskList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(taskList));
            });
            app.MapGet("/task/{id}", (int id, [FromServices] DAL<JobTask> dal) =>
            {
                var task = dal.ReadBy(t => t.Id == id);
                if (task is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(task));
            });

            app.MapPost("/task", ([FromServices] DAL<JobTask> dal, [FromBody] JobTaskRequest taskRequest) =>
            {
                dal.Create(new JobTask(taskRequest.Title, taskRequest.Owner, taskRequest.Status));
                return Results.Created();
            });

            app.MapPut("/task", ([FromServices] DAL<JobTask> dal, [FromBody] JobTaskEditRequest taskRequest) =>
            {
                var taskToEdit = dal.ReadBy(t => t.Id == taskRequest.Id);
                if (taskToEdit is null) return Results.NotFound();
                taskToEdit.Title = taskRequest.Title;
                taskToEdit.Owner = taskRequest.Owner;
                taskToEdit.Status = taskRequest.Status;
                dal.Update(taskToEdit);
                return Results.Created();
            });

            app.MapDelete("/task/{id}", ([FromServices] DAL<JobTask> dal, int id) =>
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
            task.Id,
            task.Title ?? string.Empty,
            task.Owner ?? string.Empty,
            task.Status ?? string.Empty,
            task.MachineDesign?.Id ?? 0,
            task.MachineDesign?.Name ?? "No linked equipment");
        }
    }
}
