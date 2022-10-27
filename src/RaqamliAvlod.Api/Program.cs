using Microsoft.AspNetCore.Diagnostics;
using RaqamliAvlod.Api.Configurations.Dependencies;

//-> Services
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddDataAccessLayer();
builder.AddServiceLayer();
builder.AddApiLayer();

//-> Middlewares
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
