//1.- usin to work with EntituFramework
using Microsoft.EntityFrameworkCore;
using UniversidadBacked.Controllers;
using UniversidadBacked.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2.- Connection with SQLServerExpress
const string CONNECTIONNAME = "UniversityDb";
string CONNECTIONSTRING = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3.- Add Context
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(CONNECTIONSTRING));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//TODO: Connection with SQL Server Express (DANI)


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
