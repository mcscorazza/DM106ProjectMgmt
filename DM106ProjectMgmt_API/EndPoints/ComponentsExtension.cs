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
            // Cria o grupo de endpoints para Componentes
            var groupBuilder = app.MapGroup("component")
                .RequireAuthorization()
                .WithTags("Componentes");

            // Endpoints do tipo GET para Componentes
            groupBuilder.MapGet("", ([FromServices] DAL<Components> dal) =>
            {
                var componentList = dal.Read();
                if (componentList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(componentList));
            });

            // Endpoint para obter um Componente específico pelo ID
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<Components> dal) =>
            {
                var component = dal.ReadBy(c => c.Id == id);
                if (component is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(component));
            });

            // Endpoint POST para criar um novo Componente
            groupBuilder.MapPost("", ([FromServices] DAL<Components> dal, [FromBody] ComponentsRequest componentRequest) =>
            {
                dal.Create(RequestToEntity(componentRequest));
                return Results.Created();
            });

            // Endpoint PUT para editar um Componente existente
            groupBuilder.MapPut("", ([FromServices] DAL<Components> dal, [FromBody] ComponentsEditRequest componentRequest) =>
            {
                var componentToEdit = dal.ReadBy(t => t.Id == componentRequest.Id);
                if (componentToEdit is null) return Results.NotFound();
                componentToEdit.PartNumber = componentRequest.PartNumber;
                componentToEdit.Description = componentRequest.Description;
                dal.Update(componentToEdit);
                return Results.Created();
            });

            // Endpoint DELETE para remover um Componente pelo ID
            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<Components> dal, int id) =>
            {
                var component = dal.ReadBy(t => t.Id == id);
                if (component is null) return Results.NotFound();
                dal.Delete(component);
                return Results.NoContent();
            });

        }

        // Converte uma lista de Request para uma lista de Components
        private static Components RequestToEntity(ComponentsRequest componentsRequest)
        {
            return new Components() { PartNumber = componentsRequest.PartNumber, Description = componentsRequest.Description };
        }

        // Converte a lista de Components para uma lista de Response
        private static ICollection<ComponentsResponse> EntityListToResponseList(IEnumerable<Components> entities)
        {
            return entities.Select(a => EntityToResponse(a)).ToList();
        }

        // Converte uma entidade Componentes para um Response
        private static ComponentsResponse EntityToResponse(Components entity)
        {
            return new ComponentsResponse(entity.PartNumber, entity.Description);
        }
    }
}