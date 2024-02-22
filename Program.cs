using Microsoft.EntityFrameworkCore;
using PhBet5;
using PhBet5.Components;
using PhBet5.Models;
using PhBet5.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BettingContext") ??
throw new InvalidOperationException("Connection string BettingContext not found")));

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserBettingService>();
builder.Services.AddScoped<BetsService>();
builder.Services.AddScoped<GameScoreService>();
//builder.Services.AddScoped<BetsModel>();
//builder.Services.AddScoped<UserBettingModel>();
builder.Services.AddSingleton<LoggedInUserModel>();

builder.Services.AddBlazorBootstrap();

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
