
using MovieWebSocketService;
using Microsoft.Extensions.DependencyInjection;

using System;

/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ActorsEndpoint>();
builder.Services.AddSingleton<MoviesEndpoint>();


var app = builder.Build();
//var app = builder.Build();
app.UseStaticFiles();
app.UseWebSockets();

app.UseMiddleware<WebSocketMiddleware>();



app.Run();


