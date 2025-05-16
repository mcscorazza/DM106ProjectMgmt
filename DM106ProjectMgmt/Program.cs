using System.Threading.Tasks.Dataflow;
using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using Microsoft.AspNetCore.Mvc;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/design", ([FromServices]DAL<MachineDesign> dal) =>
        {
            return Results.Ok(dal.Read());
        }
        );

        app.MapPost("/design", ([FromServices]DAL<MachineDesign> dal, MachineDesign design) =>
        {
            dal.Create(design);
            return Results.Created();
        });

        app.MapDelete("/design/{id}", ([FromServices]DAL<MachineDesign> dal, int id) =>
        {
            var design = dal.ReadBy(d => d.Id == id);
            if (design is null)
            {
                return Results.NotFound();
            }
            dal.Delete(design);
            return Results.NoContent();
        });

        app.MapPut("/design", ([FromServices] DAL<MachineDesign> dal, [FromBody]MachineDesign design) =>
        {
            var designToEdit = dal.ReadBy(d => d.Id == design.Id);
            if (designToEdit is null){ return Results.NotFound(); }
            designToEdit.Name = design.Name;
            designToEdit.DrawingCode = design.DrawingCode;
            designToEdit.Client = design.Client;
            dal.Update(designToEdit);
            return Results.Created();
        });

        app.Run();
    }
}