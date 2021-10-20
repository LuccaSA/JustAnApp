var app = WebApplication.CreateBuilder(args).Build();
var env = () => Environment.GetEnvironmentVariable("ENV");

app.MapGet("/", () => $"We're running on {env()}");

app.Run();
