var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// .use method allows the next middleware to be executed

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Anup Chand \n");
    await next(context);
});


app.Run(async (context) =>      //the .run method does not allow method below it to be executed
{
    await context.Response.WriteAsync("Welcome to ASP.Net core 9 \n");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Anup Chand");
    
});


app.Run();
