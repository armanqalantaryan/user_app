using Microsoft.EntityFrameworkCore;
using user_app.Components;
using user_app.Data;
using user_app.Services;
using user_app.Services.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Add Auth and User services to the container

builder.Services.AddScoped<IAuthService, AuthService>()

//Add Db context

builder.Services.AddDbContext<ApplicationDbContext>(opttions => 
    opttions.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();