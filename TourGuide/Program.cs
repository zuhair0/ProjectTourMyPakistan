using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TourGuide.Data;
using ClassLibraryServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<TourGuidService>();
builder.Services.AddHttpClient<ITourGuidService, TourGuidService>(c =>
{
    c.BaseAddress = new Uri("https://localhost:7054");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
