using Gadajec.Shared.Rooms.Queries;
using Gadajec.Shared.Users.Commands;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<ApiUserVm>> GetAllUsersAsync();
        Task<List<ContactVm>> GetAllContactsAsync(string userName);
        Task AddContactAsync(AddContact contactVm);
        Task DeleteContactAsync(DeleteContact contactVm);
    }
}
