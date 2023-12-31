using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Studentwebapi.Models;
using Studentwebapi.database;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnectstring")));

builder.Services.AddCors((corsoptions) =>

{

  corsoptions.AddPolicy("Mypolicy", (policyoptions) =>

  {

    policyoptions.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();

  });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
app.UseCors("Mypolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
