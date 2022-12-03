

using Gadajec.Shared.Rooms.Queries;

namespace Gadajec.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string PostRelativeUrl = "api/rooms";
        public async Task<List<RoomForListVm>> GetAllRoomsAsync() =>
            await this.GetAsync<List<RoomForListVm>>(PostRelativeUrl);

        //public async Task AddRoomAsync(AddPostVM post) =>
        //    await this.PostAsync<AddPostVM>(PostRelativeUrl, post);
    }
}
