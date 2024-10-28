using Microsoft.EntityFrameworkCore;
using PatientForms.API.Extensions;
using PatientForms.EF.Configurations.DataContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(connString));

builder.Services.RegisterServices();

var app = builder.Build();

app.MapControllers();

app.Run();
