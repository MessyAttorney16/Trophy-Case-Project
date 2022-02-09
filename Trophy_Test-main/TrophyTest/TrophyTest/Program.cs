using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrophyTest.Data;
using TrophyTest.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<TrophyTestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TrophyTestContext")));
builder.Services.AddTransient<JsonFileTrophyService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
