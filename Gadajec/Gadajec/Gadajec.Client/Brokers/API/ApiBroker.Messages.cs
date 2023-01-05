using Gadajec.Shared.Messages.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string MessageRelativeUrl = "api/messages";
        public async Task<List<MessageVm>> GetMessagesAsync(string roomName) =>
            await this.GetAsync<List<MessageVm>>(MessageRelativeUrl + $"/{roomName}");

        public async Task SendMessageAsync(MessageVm messageVm) =>
            await this.PostAsync<MessageVm>(MessageRelativeUrl + "/send", messageVm);

    }
}
