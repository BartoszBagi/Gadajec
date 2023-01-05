using Gadajec.Shared.Messages.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<MessageVm>> GetMessagesAsync(string roomName);
        Task SendMessageAsync(MessageVm messageVm);
    }
}
