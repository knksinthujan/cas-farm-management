using FarmApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        policy =>
        {
            //policy.WithOrigins("https://localhost:7053") // Allow specific origin
            policy.AllowAnyOrigin()
                  .AllowAnyMethod() // Allow any HTTP method
                  .AllowAnyHeader(); // Allow any header
        });
});

// Add services to the container.
builder.Services.AddDbContext<FarmDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("FarmManagementDb")));

builder.Services.AddScoped<IFieldService, FieldService>();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseCors("AllowSpecificOrigins");

app.MapEndPoints();

app.Run();


