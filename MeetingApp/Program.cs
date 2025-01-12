var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//controller/action/id
app.MapDefaultControllerRoute();

app.UseRouting();

app.UseStaticFiles();

app.Run();
