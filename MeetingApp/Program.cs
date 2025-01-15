var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//controller/action/id
app.MapDefaultControllerRoute();

app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{Id?}"
);

app.UseStaticFiles();

app.Run();
