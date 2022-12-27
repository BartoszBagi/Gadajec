

using Gadajec.Shared.Rooms.Commands;
using Gadajec.Shared.Rooms.Queries;

namespace Gadajec.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string RoomRelativeUrl = "api/rooms";
        public async Task<List<RoomForListVm>> GetAllRoomsAsync() =>
            await this.GetAsync<List<RoomForListVm>>(RoomRelativeUrl);

        public async Task AddRoomAsync(AddRoomVm room) =>
            await this.PostAsync<AddRoomVm>(RoomRelativeUrl + "/addRoom", room);
        public async Task DeleteRoomAsync(Guid roomId) =>
            await this.PostAsync<Guid>(RoomRelativeUrl + "/deleteRoom", roomId);

        //public async Task AddRoomUserAsync(Guid userId, Guid roomId) =>
        //    await this.PostAsync<>(RoomRelativeUrl + "/addUser", userId, roomId);
    }
}
