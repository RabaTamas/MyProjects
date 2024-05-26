using MovieWebSocketService.Data;
using MovieWebSocketService.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.WebSockets;
using System.Text;

namespace MovieWebSocketService
{
    public abstract class BaseEndpoint
    {

        public async Task Open(WebSocket socket)
        {
            Console.WriteLine("WebSocket opened.");
        }
        public async Task Close(WebSocket socket)
        {
            Console.WriteLine("WebSocket closed.");
        }
        public async Task Error(WebSocket socket, Exception ex)
        {
            Console.WriteLine("WebSocket error: " + ex.Message);
        }
        public async Task<string> Message(WebSocket socket, string message)
        {
            Console.WriteLine($"WebSocket message: {message}");

            return $"Hello: {message}";
        }

        public abstract Task<string> Create(WebSocket socket, Dictionary<string,string> message);

        public abstract Task<string> Delete(WebSocket socket, Dictionary<string, string> message);

        public abstract Task<string> GetEntities(WebSocket socket);

        public abstract Task<string> ListEntities(WebSocket socket);


       

    }
}
