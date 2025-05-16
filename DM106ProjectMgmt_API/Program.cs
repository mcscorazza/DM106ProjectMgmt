using System.Text.Json.Serialization;
using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<DM106ProjectMgmtContext>();
builder.Services.AddTransient<DAL<MachineDesign>>();
var app = builder.Build();

app.MapGet("/design", ([FromServices] DAL<MachineDesign> dal) =>
{ 
    return Results.Ok(dal.Read());
}
);

app.MapPost("/design", ([FromServices] DAL<MachineDesign> dal, MachineDesign design) =>
{
    dal.Create(design);
    return Results.Created();
});

app.MapPut("/design", ([FromServices] DAL<MachineDesign> dal, [FromBody] MachineDesign design) =>
{
    var designToEdit = dal.ReadBy(d => d.Id == design.Id);
    if (designToEdit is null) return Results.NotFound();
    designToEdit.Name = design.Name;
    designToEdit.DrawingCode = design.DrawingCode;
    designToEdit.Client = design.Client;
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

app.Run();
