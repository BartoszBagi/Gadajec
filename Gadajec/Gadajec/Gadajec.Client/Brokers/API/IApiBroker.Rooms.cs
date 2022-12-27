using Gadajec.Shared.Rooms.Commands;
using Gadajec.Shared.Rooms.Queries;

namespace Gadajec.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<RoomForListVm>> GetAllRoomsAsync();
        Task AddRoomAsync(AddRoomVm room);
        Task DeleteRoomAsync(Guid room);
        //Task AddRoomUserAsync(Guid userId, Guid roomId);
    }
}

