var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add static files middleware FIRST
app.UseStaticFiles();

// Then define endpoints
app.MapGet("/", () => "Hello World!");

app.Run();
