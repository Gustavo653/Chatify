using Microsoft.AspNetCore.SignalR;

namespace Chatify.Service
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"Mensagem de {user}: {message}");
            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }
    }
}