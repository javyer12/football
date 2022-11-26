using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eframework;
using eframework.Models;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddNpgsql<FootContext>(builder.Configuration.GetConnectionString("Football"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/players", ([FromServices]FootContext dbContext)=> 
{
    return Results.Ok("Now we are connected");
});
app.MapGet("/api/players", ([FromServices] FootContext dbContext)=> {
    return Results.Ok(dbContext.Players);
});
app.Run();
