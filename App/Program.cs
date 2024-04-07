var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints((endpoint)=>{endpoint.MapControllers();});

app.Run();
