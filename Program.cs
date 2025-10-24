var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/anotherroute", () => $"Hello from another route!");

app.Run("http://0.0.0.0:8080");
