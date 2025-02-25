var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapDefaultControllerRoute();


//Conventional Routing 
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=About}/{id?}"
//    );

app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();
