using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string UserRelativeUrl = "api/users";

        public async Task<List<ApiUserVm>> GetAllUsersAsync() =>
            await this.GetAsync<List<ApiUserVm>>(UserRelativeUrl);

        public async Task<List<ContactVm>> GetAllContactsAsync(string userName) =>
            await this.GetAsync<List<ContactVm>>(UserRelativeUrl + $"/{userName}");
        public async Task AddContactAsync(AddContact contactVm) =>
            await this.PostAsync<AddContact>(UserRelativeUrl + "/addContact", contactVm);
        public async Task DeleteContactAsync(DeleteContact contactVm) =>
            await this.PostAsync<DeleteContact>(UserRelativeUrl + "/deleteContact", contactVm);

    }
}
