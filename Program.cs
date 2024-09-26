using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using JoseBrito_AP1_P1.Components;
using JoseBrito_AP1_P1.DAL;
using JoseBrito_AP1_P1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddContext<Contexto>(Options => Options.UseSqlite(ConStr));

builder.Services.AddScoped<ParcialServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
