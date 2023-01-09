using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string UserRelativeUrl = "api/users";

        public async Task<List<ApiUserVm>> GetAllUsersAsync() =>
            await this.GetAsync<List<ApiUserVm>>(UserRelativeUrl);

        public async Task<List<ApiUserVm>> GetAllContactsAsync(string userName) =>
            await this.GetAsync<List<ApiUserVm>>(UserRelativeUrl + $"/{userName}");
        public async Task AddContactAsync(ContactVm contactVm) =>
            await this.PostAsync<ContactVm>(UserRelativeUrl + "/addContact", contactVm);

    }
}
