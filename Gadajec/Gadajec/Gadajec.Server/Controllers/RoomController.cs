using Gadajec.Application.Commands.RoomCommands.AddRoomUser;
using Gadajec.Application.Commands.RoomCommands.CreateRoom;
using Gadajec.Application.Commands.RoomCommands.DeleteRoom;
using Gadajec.Application.Queries.Rooms.AllRoomsQueries;
using Gadajec.Shared.Rooms.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Gadajec.Server.Controllers
{
    [ApiController]
    [Route("api/rooms")]
    public class RoomController : ApiControllerBase
    {
        public RoomController()
        {

        }

        [HttpPost("/addRoom")]
        public async Task<IActionResult> AddRoom(CreateRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("/deleteRoom")]
        public async Task<IActionResult> Delete(DeleteRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("/addUser")]
        public async Task<IActionResult> AddUser(AddUserRoomCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<RoomForListVm>> GetAsync([FromQuery] AllRoomsQuery command)
        {
            var result = await Mediator.Send(command);
            return result;
        }
    }
}
