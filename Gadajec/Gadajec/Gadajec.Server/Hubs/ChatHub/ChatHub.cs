using Gadajec.Client.Brokers.API;
using Gadajec.Shared.Messages.Commands;
using Gadajec.Shared.Messages.PreviousChatArchive;
using Microsoft.AspNetCore.SignalR;

namespace Gadajec.Server.Hubs.ChatHub
{
    public class ChatHub : Hub
    {
        public ChatHub()
        {

        }
        public async Task JoinRoom(string roomName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        }
        public async Task SendMessage(string user, string message, string roomName)
        {                         
                await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);            
        }
    }
}
