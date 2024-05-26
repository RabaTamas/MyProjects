using MovieWebSocketService.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;

namespace MovieWebSocketService
{
    public class WebSocketMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ActorsEndpoint _server;
        private readonly MoviesEndpoint _moviesEndpoint;
        private class EntityHandler {

            public string request_type { get; set; }
            public string action_type { get; set; }

            public Dictionary<string, string> entity;


        }

        
        public WebSocketMiddleware(RequestDelegate next, MoviesEndpoint moviesEndpoint, ActorsEndpoint server)
        {
            _next = next;
            _server = server;


            _moviesEndpoint = moviesEndpoint;

        }
        public async Task Invoke(HttpContext context)
        {
            if (!context.WebSockets.IsWebSocketRequest) return;
            var socket = await context.WebSockets.AcceptWebSocketAsync();
            await _moviesEndpoint.Open(socket);
            
            try
            {
                while (socket.State == WebSocketState.Open)
                {
                    await HandleMessage(socket);
                }
            }
            catch (Exception ex)
            {
                await _moviesEndpoint.Close(socket);
                await socket.CloseAsync(WebSocketCloseStatus.InternalServerError,
                ex.Message, CancellationToken.None);
                throw;
            }
        }
        

        private async Task HandleMessage(WebSocket socket)
        {
            var request = await StringEncoder.ReceiveAsync(socket);

            if (request.message != null)
            {
                if (request.message.Contains("actors"))
                {
                    var response = await HandleActorMessage(socket, request.message);
                    await StringEncoder.SendAsync(socket, response);
                }
                else if (request.message.Contains("movies"))
                {
                    var response = await HandleMovieMessage(socket, request.message);
                    await StringEncoder.SendAsync(socket, response);
                }
            }
            else if (request.result.MessageType == WebSocketMessageType.Close)
            {
                await _server.Close(socket);
                await socket.CloseAsync(WebSocketCloseStatus.NormalClosure,
                    null, CancellationToken.None);
            }
        }

        private async Task<string> HandleActorMessage(WebSocket socket, string message)
        {
            string response = "No response";

            var handler = JsonConvert.DeserializeObject<EntityHandler>(message);

            if (handler.action_type.Equals("create"))
            {
                response = await _server.Create(socket, handler.entity);
            }
            else if (handler.action_type.Equals("delete"))
            {

                response = await _server.Delete(socket, handler.entity);

            }
            else if (handler.action_type.Equals("loadMovies"))
            {

                response = await _server.GetEntities(socket);
            }
            else if (handler.action_type.Equals("list"))
            {
                response = await _server.ListEntities(socket);
            }

            return response;
        }

        private async Task<string> HandleMovieMessage(WebSocket socket, string message)
        {
            string response = "No response";

            var handler = JsonConvert.DeserializeObject<EntityHandler>(message);

            if (handler.action_type.Equals("create"))
            {
                response = await _moviesEndpoint.Create(socket, handler.entity);
            }
            else if (handler.action_type.Equals("delete"))
            {
                response = await _moviesEndpoint.Delete(socket, handler.entity);
            }
            else if (handler.action_type.Equals("loadActors"))
            {

                response = await _moviesEndpoint.GetEntities(socket);
            }
            else if (message.Contains("list"))
            {
                response = await _moviesEndpoint.ListEntities(socket);
            }

            return response;
        }
    }
}
