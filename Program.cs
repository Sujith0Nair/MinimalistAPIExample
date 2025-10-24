var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/anotherroute", () => $"Hello from another route!");

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
var url = app.Environment.IsDevelopment() ? null : $"https://0.0.0.0:{port}";

app.Run(url);