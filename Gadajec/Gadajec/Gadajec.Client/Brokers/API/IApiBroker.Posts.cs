using Gadajec.Shared.Rooms.Queries;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<RoomForListVm>> GetAllRoomsAsync();
        //Task AddPostAsync(AddPostVM post);
    }
}
