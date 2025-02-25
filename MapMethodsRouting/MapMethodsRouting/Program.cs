var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();

// all the belwoe middleware are use when we have to use custom middle ware

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page GET");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page Post");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page Put");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home Page Delete");
    });
});

app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Page not found please put the correct URL");
});

//app.Map("/Home", () => "Hello World!");

//app.MapGet("/Home", () => "Hello World! - Get ");
//app.MapPost("/Home", () => "Hello World! - Post");
//app.MapPut("/Home", () => "Hello World! - PUT");
//app.MapDelete("/Home", () => "Hello World! - Delete");



app.Run();
