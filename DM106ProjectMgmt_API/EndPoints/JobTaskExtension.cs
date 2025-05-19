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
            // Criar o grupo de endpoints para JobTasks
            var groupBuilder = app.MapGroup("task")
                .RequireAuthorization()
                .WithTags("Tarefas");

            // Endpoint GET para obter todas as Tarefas
            groupBuilder.MapGet("", ([FromServices] DAL<JobTask> dal) =>
            {
                var taskList = dal.Read();
                if (taskList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(taskList));
            });

            // Endpoint GET para obter uma Tarefa específica pelo ID
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<JobTask> dal) =>
            {
                var task = dal.ReadBy(t => t.Id == id);
                if (task is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(task));
            });

            // Endpoint POST para criar uma nova Tarefa
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

            // Endpoint PUT para editar uma Tarefa existente
            groupBuilder.MapPut("", ([FromServices] DAL<JobTask> dal, [FromBody] JobTaskEditRequest taskRequest) =>
            {
                // Verifica se a Tarefa a ser editado existe
                var taskToEdit = dal.ReadBy(t => t.Id == taskRequest.Id);

                // Se a Tarefa não existir, retorna um erro 404 (Not Found)
                if (taskToEdit is null) return Results.NotFound();

                // Recupera os dados da Tarefa a ser editada
                taskToEdit.Title = taskRequest.Title;
                taskToEdit.Owner = taskRequest.Owner;
                taskToEdit.Status = taskRequest.Status;
                taskToEdit.MachineDesignId = taskRequest.MachineDesignId;

                // Atualiza a Tarefa no banco de dados
                dal.Update(taskToEdit);

                // Retorna uma resposta indicando que a atualização foi bem-sucedida
                return Results.Created();
            });

            // Endpoint DELETE para remover uma Tarefa pelo ID
            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<JobTask> dal, int id) =>
            {
                var task = dal.ReadBy(t => t.Id == id);
                if (task is null) return Results.NotFound();
                dal.Delete(task);
                return Results.NoContent();
            });
        }

        // Converte uma lista de Tarefas para uma lista de Response
        private static ICollection<JobTaskResponse> EntityListToResponseList(IEnumerable<JobTask> taskList)
        {
            return taskList.Select(a => EntityToResponse(a)).ToList();
        }

        // Converte uma entidade Tarefa para um Response
        private static JobTaskResponse EntityToResponse(JobTask task)
        {
            return new JobTaskResponse(
            task.Title ?? string.Empty,
            task.Owner ?? string.Empty,
            task.Status ?? string.Empty);
        }
    }
}
