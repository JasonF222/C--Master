using WeddingPlanner.Models;  // <== INSERT YOUR PROJECT NAME HERE //
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var googleMapsApiKey = builder.Configuration.GetValue<string>("GoogleMapsAPIKey");
var googleMapsAPIConfiguration = new GoogleMapsAPIConfiguration(googleMapsApiKey);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
// Anytime dependency injection is used, it will always be that exact instance from line 9 //
// API Key will always be available //
builder.Services.AddSingleton(googleMapsAPIConfiguration);
builder.Services.AddDbContext<WeddingContext>( options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
