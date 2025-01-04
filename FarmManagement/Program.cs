using MudBlazor.Services;
using FarmManagement.Client.Pages;
using FarmManagement.Components;
using Microsoft.EntityFrameworkCore;
using MyApplication.Client;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContext<FarmDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("FarmManagementDb")));
//builder.Services.AddDbContext<FarmDbContext>(x => x.UseSqlServer("Server=SINTHUJAN;Database=FarmManagement;User ID=sa;Password=123456;TrustServerCertificate=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FarmManagement.Client._Imports).Assembly);

app.Run();
