var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/", () => "Hello World!");

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.Run();
