using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<ApiUserVm>> GetAllUsersAsync();
        Task<List<ApiUserVm>> GetAllContactsAsync(string userName);
        Task AddContactAsync(ContactVm contactVm);
    }
}
