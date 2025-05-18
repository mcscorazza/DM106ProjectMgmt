using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.Requests;
using DM106ProjectMgmt_API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DM106ProjectMgmt_API.EndPoints
{
    public static class RequirementExtension
    {
        public static void AddEndPointsRequirement(this WebApplication app)
        {
            var groupBuilder = app.MapGroup("requirement")
                .RequireAuthorization()
                .WithTags("Requirements");

            // Endpoints para JobTasks
            groupBuilder.MapGet("", ([FromServices] DAL<Requirement> dal) =>
            {
                var reqList = dal.Read();
                if (reqList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(reqList));
            });
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<Requirement> dal) =>
            {
                var req = dal.ReadBy(r => r.Id == id);
                if (req is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(req));
            });

            groupBuilder.MapPost("", ([FromServices] DAL<Requirement> dal, [FromBody] RequirementRequest reqRequest) =>
            {
                dal.Create(
                    new Requirement(
                        reqRequest.Description, 
                        reqRequest.Type,
                        reqRequest.MachineDesignId
                    ));
                return Results.Created();
            });

            groupBuilder.MapPut("", ([FromServices] DAL<Requirement> dal, [FromBody] RequirementEditRequest reqRequest) =>
            {
                var reqToEdit = dal.ReadBy(t => t.Id == reqRequest.Id);
                
                if (reqToEdit is null) return Results.NotFound();
                
                reqToEdit.Description = reqRequest.Description;
                reqToEdit.Type = reqRequest.Type;
                reqToEdit.MachineDesignId = reqRequest.MachineDesignId;
                
                dal.Update(reqToEdit);
                return Results.Created();
            });

            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<Requirement> dal, int id) =>
            {
                var req = dal.ReadBy(r => r.Id == id);
                if (req is null) return Results.NotFound();
                dal.Delete(req);
                return Results.NoContent();
            });
        }
        private static ICollection<RequirementResponse> EntityListToResponseList(IEnumerable<Requirement> reqList)
        {
            return reqList.Select(a => EntityToResponse(a)).ToList();
        }
        private static RequirementResponse EntityToResponse(Requirement req)
        {
            return new RequirementResponse(
                req.Description ?? string.Empty,
                req.Type ?? string.Empty
                );
        }
    }
}

