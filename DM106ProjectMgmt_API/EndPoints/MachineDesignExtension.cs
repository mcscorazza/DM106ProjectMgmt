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
        // Método de extensão para adicionar os endpoints relacionados a Projetos
        public static void AddEndPointsMachineDesign(this WebApplication app)
        {
            // Cria o grupo de endpoints para Projetos
            var groupBuilder = app.MapGroup("design")
                .RequireAuthorization()
                .WithTags("Projetos");

            // Endpoint GET para obter todos os Projetos
            groupBuilder.MapGet("", ([FromServices] DAL<MachineDesign> dal) =>
            {
                var designList = dal.Read();
                if (designList is null) return Results.NotFound();
                return Results.Ok(EntityListToResponseList(designList));
            }
            );

            // Endpoint GET para obter um Projeto específico pelo ID
            groupBuilder.MapGet("/{id}", (int id, [FromServices] DAL<MachineDesign> dal) =>
            {
                var design = dal.ReadBy(d => d.Id == id);
                if (design is null) return Results.NotFound();
                return Results.Ok(EntityToResponse(design));
            });

            // Endpoint POST para criar um novo Projeto
            groupBuilder.MapPost("", ([FromServices] DAL<MachineDesign> dal, [FromServices] DAL<Components> dalComponents, [FromBody] MachineDesignRequest design) =>
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

            // Endpoint PUT para editar um Projeto existente
            groupBuilder.MapPut("", ([FromServices] DAL<MachineDesign> dal, [FromBody] MachineDesignEditRequest designRequest) =>
            {
                var designToEdit = dal.ReadBy(d => d.Id == designRequest.Id);
                if (designToEdit is null) return Results.NotFound();
                designToEdit.Name = designRequest.Name;
                designToEdit.DrawingCode = designRequest.DrawingCode;
                designToEdit.Client = designRequest.Client;
                dal.Update(designToEdit);
                return Results.Created();
            });

            // Endpoint DELETE para remover um Projeto existente
            groupBuilder.MapDelete("/{id}", ([FromServices] DAL<MachineDesign> dal, int id) =>
            {
                var design = dal.ReadBy(d => d.Id == id);
                if (design is null) return Results.NotFound();
                dal.Delete(design);
                return Results.NoContent();
            });
        }

        // Converte a lista de Componentes para uma lista de Response
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

        // Converte um Request para um Componente
        private static Components RequestToEntity(ComponentsRequest componentRequest)
        {
            return new Components() { 
                PartNumber = componentRequest.PartNumber, 
                Description = componentRequest.Description 
            };
        }


        // Converte a lista de Projetos para uma lista de Response
        private static ICollection<MachineDesignResponse> EntityListToResponseList(IEnumerable<MachineDesign> entities)
        {
            return entities.Select(e => EntityToResponse(e)).ToList();
        }

        // Converte um projeto para um Response
        private static MachineDesignResponse EntityToResponse(MachineDesign entity)
        {
            return new MachineDesignResponse(
                entity.Id, 
                entity.Name, 
                entity.DrawingCode, 
                entity.Client, 
                entity.JobTasks.Select(task => new JobTaskResponse(
                    task.Title,
                    task.Owner,
                    task.Status)).ToList(),
                entity.Requirement.Select(req => new RequirementResponse(
                    req.Description,
                    req.Type)).ToList(),
                entity.Components.Select(comp => new ComponentsResponse(
                    comp.PartNumber,
                    comp.Description)).ToList()
                );
        }
    }
}