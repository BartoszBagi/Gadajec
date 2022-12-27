using Gadajec.Client.Brokers.API;
using Gadajec.Shared.Rooms.Queries;

namespace Gadajec.Client.Service.Rooms
{
    public partial class RoomsService : IRoomsService
    {

        private readonly IApiBroker apiBroker;

        public RoomsService(IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async Task<List<RoomForListVm>> GetAllRoomsAsync() =>
            await apiBroker.GetAllRoomsAsync();

       
    }
}
