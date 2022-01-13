using Microsoft.EntityFrameworkCore;

using SistemaSolarApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<PlanetaContext>(opt => opt.UseMySql(

builder.Configuration.GetConnectionString("mysqlConnection"),
 new MySqlServerVersion(new Version())
));

//https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen(); cria uma pagina com descrição das api do projeto

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
