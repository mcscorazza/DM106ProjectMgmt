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
                return Results.Ok(EntityListToResponseList(designList));
            }
            );
            app.MapGet("/design/{id}", (int id, [FromServices] DAL<MachineDesign> dal) =>
            {
                var design = dal.ReadBy(d => d.Id == id);
                if (design is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(design));
            });

            app.MapPost("/design", ([FromServices] DAL<MachineDesign> dal, [FromServices] DAL<Components> dalComponents, [FromBody] MachineDesignRequest design) =>
            {
                var machineDesign = new MachineDesign(design.Name, design.DrawingCode, design.Client)
                {
                    Components = design.Components is not null ?
                        ComponentRequestConverter(design.Components, dalComponents) :
                        new List<Components>()
                };
                dal.Create(machineDesign);
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

        // Converte a lista de Componentes para uma lista de respostas
        private static ICollection<Components> ComponentRequestConverter(
            ICollection<ComponentsRequest> components,
            DAL<Components> dalComponents)
        {
            var compList = new List<Components>();
            foreach (var item in components)
            {
                var entity = RequestToEntity(item);
                var comp = dalComponents.ReadBy(l => l.PartNumber.ToUpper().Equals(entity.PartNumber.ToUpper()));
                if (comp is not null) compList.Add(comp);
                else compList.Add(entity);
            }
            return compList;
        }

        private static Components RequestToEntity(ComponentsRequest componentRequest)
        {
            return new Components() { 
                PartNumber = componentRequest.PartNumber, 
                Description = componentRequest.Description 
            };
        }


        // Converte a lista de Projetos para uma lista de respostas
        private static ICollection<MachineDesignResponse> EntityListToResponseList(IEnumerable<MachineDesign> entities)
        {
            return entities.Select(a => EntityToResponse(a)).ToList();
        }
        // Converte um projeto para uma resposta
        private static MachineDesignResponse EntityToResponse(MachineDesign entity)
        {
            return new MachineDesignResponse(entity.Id, entity.Name, entity.DrawingCode, entity.Client);
        }
    }
}