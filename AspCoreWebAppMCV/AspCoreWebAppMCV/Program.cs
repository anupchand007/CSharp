// Create a new builder for the web application and pass command-line arguments
var builder = WebApplication.CreateBuilder(args);

// Add services to the container, which includes the necessary services for the MVC pattern
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline for the app

// Check if the app is not in the development environment
if (!app.Environment.IsDevelopment())
{
    // Use the exception handler to redirect to a custom error page if an unhandled exception occurs
    app.UseExceptionHandler("/Home/Error");

    // Add HTTP Strict Transport Security (HSTS) header, typically for production environments
    // It instructs browsers to always connect over HTTPS
    // The default value for HSTS is set to 30 days, but you can adjust it for production scenarios
    app.UseHsts();
}

//All THE APP. ARE MIDDLEWARE, which will be check while running the app
// MIDDDLEWARE: it is a component (class) which is executed on every rquest in 
// ASP.NET core application


//They are pipleline which will be checked during request and run the app

// Ensure all requests are redirected to HTTPS for better security
app.UseHttpsRedirection();

// Enable the app to serve static files like CSS, JavaScript, and images
app.UseStaticFiles();

// Enable routing to map HTTP requests to controllers and actions
app.UseRouting();

// Add authorization middleware to ensure that requests are properly authorized before reaching the controller actions
app.UseAuthorization();

// Configure the default route for the application
// When a user accesses the app, it will look for a controller and action, defaulting to "Home/Index" if none are specified
app.MapControllerRoute(
    name: "default",  // This is a name for the route that can be used for URL generation
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Defines the pattern for URLs and default controller and action

// Start the web application and listen for incoming requests
app.Run();
