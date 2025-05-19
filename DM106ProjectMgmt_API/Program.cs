using System.Net;
using System.Text.Json.Serialization;
using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Data.Models;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.EndPoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// cria o Builder para os EndPoints
var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para o projeto
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<DM106ProjectMgmtContext>();
builder.Services.AddTransient<DAL<MachineDesign>>();
builder.Services.AddTransient<DAL<JobTask>>();
builder.Services.AddTransient<DAL<Requirement>>();
builder.Services.AddTransient<DAL<Components>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddIdentityApiEndpoints<AccessUser>()
    .AddEntityFrameworkStores<DM106ProjectMgmtContext>();

builder.Services.AddAuthorization();

var app = builder.Build();

// Configura o pipeline de requisições
app.UseAuthorization();
app.AddEndPointsMachineDesign();
app.AddEndPointsJobTask();
app.AddEndPointsComponents();
app.AddEndPointsRequirement();

app.UseSwagger();
app.UseSwaggerUI();

// Configura o pipeline de autenticação
app.MapGroup("auth").MapIdentityApi<AccessUser>().WithTags("Authoization");

// Cria um endpoint para o LOGOUT
app.MapPost("auth/logout", async ([FromServices] SignInManager<AccessUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Ok();
}).RequireAuthorization().WithTags("Authorization");

app.Run();
