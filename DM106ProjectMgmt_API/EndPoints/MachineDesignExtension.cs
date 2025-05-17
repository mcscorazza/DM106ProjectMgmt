using System.Runtime.CompilerServices;
using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.Requests;
using DM106ProjectMgmt_API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DM106ProjectMgmt_API.EndPoints
{
    public static class MachineDesignExtension
    {

        public static void AddEndPointsMachineDesign(this WebApplication app)
        {
            // Endpoints para MachineDesign
            app.MapGet("/design", ([FromServices] DAL<MachineDesign> dal) =>
            {
                var designList = dal.Read();
                if (designList is null) return Results.NotFound();
                var designResponseList = EntityListToResponseList(designList);
                return Results.Ok(designResponseList);
            }
            );

            app.MapPost("/design", ([FromServices] DAL<MachineDesign> dal, [FromBody] MachineDesignRequest designRequest) =>
            {
                var design = new MachineDesign(designRequest.Name, designRequest.DrawingCode, designRequest.Client);
                dal.Create(design);
                return Results.Created();
            });

            app.MapPut("/design", ([FromServices] DAL<MachineDesign> dal, [FromBody] MachineDesignEditRequest designRequest) =>
            {
                var designToEdit = dal.ReadBy(d => d.Id == designRequest.Id);
                if (designToEdit is null) return Results.NotFound();
                designToEdit.Name = designRequest.Name;
                designToEdit.DrawingCode = designRequest.DrawingCode;
                designToEdit.Client = designRequest.Client;
                dal.Update(designToEdit);
                return Results.Created();
            });

            app.MapDelete("/design/{id}", ([FromServices] DAL<MachineDesign> dal, int id) =>
            {
                var design = dal.ReadBy(d => d.Id == id);
                if (design is null) return Results.NotFound();
                dal.Delete(design);
                return Results.NoContent();
            });
        }

        private static ICollection<MachineDesignResponse> EntityListToResponseList(IEnumerable<MachineDesign> entities)
        {
            return entities.Select(a => EntityToResponse(a)).ToList();
        }
        private static MachineDesignResponse EntityToResponse(MachineDesign entity)
        {
            return new MachineDesignResponse(entity.Id, entity.Name, entity.DrawingCode, entity.Client);
        }

    }
}
