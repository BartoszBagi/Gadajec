using Microsoft.AspNetCore.SignalR;

namespace Gadajec.Server.Hubs.ChatHub
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await AddMessageToChat("", "User connected!");
            await base.OnConnectedAsync();
        }
        public async Task AddMessageToChat(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}
