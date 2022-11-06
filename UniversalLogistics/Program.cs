using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using UniversalLogistics.Data;
using UniversalLogistics.Extensions;

var builder = WebApplication.CreateBuilder(args);


/* 
 Services that are required by the app are configured
 The app's request handling pipeline is defined as a series of middleware components
 */


// Add services to the container.
builder.Services.AddControllersWithViews();

// Register DBContext in dependency injection

var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
var connectionString = builder.Configuration.GetConnectionString("LogisticsDatabase");

builder.Services.AddDbContext<LogisticsContext>(
	options => options.UseMySql(connectionString, serverVersion)
);

builder.Services.AddScoped<IDBInitialiser, CategorySeeding>();


//CategorySeeding.Seed(builder.Configuration["JSONPaths:Materials"]);


var app = builder.Build();
app.SeedSQLDatabase();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Pages/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();


app.MapControllers();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Pages}/{action=Index}/{id?}");


app.Run();