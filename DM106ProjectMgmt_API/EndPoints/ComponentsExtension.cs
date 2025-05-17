using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.Requests;
using DM106ProjectMgmt_API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DM106ProjectMgmt_API.EndPoints
{
    public static class ComponentsExtension
    {
        public static void AddEndPointsComponents(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("component")
                .RequireAuthorization()
                .WithTags("Components");

            // Endpoints para JobTasks
            groupBuilder.MapGet("", ([FromServices] DAL<Components> dal) =>
            {
                var componentList = dal.Read();
                if (componentList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(componentList));
            });
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<Components> dal) =>
            {
                var component = dal.ReadBy(c => c.Id == id);
                if (component is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(component));
            });

            groupBuilder.MapPost("", ([FromServices] DAL<Components> dal, [FromBody] ComponentsRequest componentRequest) =>
            {
                dal.Create(RequestToEntity(componentRequest));
                return Results.Created();
            });

            groupBuilder.MapPut("", ([FromServices] DAL<Components> dal, [FromBody] ComponentsEditRequest componentRequest) =>
            {
                var componentToEdit = dal.ReadBy(t => t.Id == componentRequest.Id);
                if (componentToEdit is null) return Results.NotFound();
                componentToEdit.PartNumber = componentRequest.PartNumber;
                componentToEdit.Description = componentRequest.Description;
                dal.Update(componentToEdit);
                return Results.Created();
            });

            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<Components> dal, int id) =>
            {
                var component = dal.ReadBy(t => t.Id == id);
                if (component is null) return Results.NotFound();
                dal.Delete(component);
                return Results.NoContent();
            });

        }

        private static Components RequestToEntity(ComponentsRequest componentsRequest)
        {
            return new Components() { PartNumber = componentsRequest.PartNumber, Description = componentsRequest.Description };
        }

        // Converte a lista de Projetos para uma lista de respostas
        private static ICollection<ComponentsResponse> EntityListToResponseList(IEnumerable<Components> entities)
        {
            return entities.Select(a => EntityToResponse(a)).ToList();
        }
        // Converte um projeto para uma resposta
        private static ComponentsResponse EntityToResponse(Components entity)
        {
            return new ComponentsResponse(entity.PartNumber, entity.Description);
        }
    }
}
