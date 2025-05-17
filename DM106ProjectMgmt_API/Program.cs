using System.Text.Json.Serialization;
using DM106ProjectMgmt.Shared.Data.DB;
using DM106ProjectMgmt.Shared.Models;
using DM106ProjectMgmt_API.EndPoints;


var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddDbContext<DM106ProjectMgmtContext>();
builder.Services.AddTransient<DAL<MachineDesign>>();
builder.Services.AddTransient<DAL<JobTask>>();
builder.Services.AddTransient<DAL<Components>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddEndPointsMachineDesign();
app.AddEndPointsJobTask();
app.AddEndPointsComponents();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
